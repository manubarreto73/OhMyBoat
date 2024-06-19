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

    var config = {
        displayModeBar: false // This will hide the mode bar
    }

    Plotly.newPlot(id, data, layout, config);
};

window.renderPlotlyPieChart = function (id, values, labels, title, xSize, ySize) {
    var data = [{
        values: values,
        labels: labels,
        type: 'pie',
        hoverinfo: 'label+value',
        textinfo: "label+percent",
        textposition: "outside",
        hovertemplate: "%{value}&nbsp;" + "Intercambios %{label}" + "<extra></extra>"
    }];

    var layout = {
        title: title,
        height: xSize,
        width: ySize,
    };

    var config = {
        displayModeBar: false // This will hide the mode bar
    }

    Plotly.newPlot(id, data, layout, config);
};

window.exportPlotlyChartToPdf = function (chartId1, chartId2) {
    const { jsPDF } = window.jspdf;

    const promise1 = Plotly.toImage('intercambios', { format: 'png', width: 1000, height: 700 });
    const promise2 = Plotly.toImage('sedes', { format: 'png', width: 1000, height: 700 });

    Promise.all([promise1, promise2])
        .then(function ([imgData1, imgData2]) {
            const pdf = new jsPDF();
            pdf.addImage(imgData1, 'PNG', 30, 20, 120, 67);
            pdf.addImage(imgData2, 'PNG', 10, 100, 170, 100);
            pdf.save('charts.pdf');
        });
};