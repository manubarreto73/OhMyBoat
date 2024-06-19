window.renderPlotlyBarChart = function (id, xData, yData, title, xSize, ySize) {
    var data = [{
        x: xData,
        y: yData,
        type: "bar"
    }];

    var layout = {
        title: title,
        height: xSize,
        width: ySize,
        config: {
            displayModeBar: false,
            displaylogo: false
        }
    };

    Plotly.newPlot(id, data, layout);
};

window.renderPlotlyPieChart = function (id, values, labels, title, xSize, ySize) {
    var data = [{
        values: values,
        labels: labels,
        type: "pie",
    }];

    var layout = {
        title: title,
        height: xSize,
        width: ySize,
        hoverinfo: "label+percent",
        hovertemplate:
            ""
    };

    Plotly.newPlot(id, data, layout);
};

window.exportPlotlyChartToPdf = function (chartId1, chartId2) {
    const { jsPDF } = window.jspdf;

    const promise1 = Plotly.toImage('intercambios', { format: 'png', width: 1000, height: 700 });
    const promise2 = Plotly.toImage('sedes', { format: 'png', width: 1000, height: 700 });

    Promise.all([promise1, promise2])
        .then(function ([imgData1, imgData2]) {
            const pdf = new jsPDF();
            pdf.addImage(imgData1, 'PNG', 10, 10, 190, 100);
            pdf.addPage();
            pdf.addImage(imgData2, 'PNG', 10, 10, 190, 100);
            pdf.save('charts.pdf');
        });
};