﻿window.renderPlotlyBarChart = function (id, xData, yData, title, xSize, ySize) {
    var data = [{
        x: xData,
        y: yData,
        type: "bar",
        marker: {
            color: '#03045e'  // Orange color
        }
    }];

    var layout = {
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
        textinfo: "label+value+percent",
        textposition: "outside",
        texttemplate: "<b>%{label} <br> %{percent}</b> (%{value})",
        hovertemplate: "%{value}&nbsp;" + "Intercambios %{label}" + "<extra></extra>",
        marker: {
            colors: ['#03045e', '#ff006e']  // Orange color
        }
    }];

    var layout = {
        height: xSize,
        width: ySize,
        font: {
            size: 13  // set the size of the text in the chart
        }
    };

    var config = {
        displayModeBar: false // This will hide the mode bar
    }

    Plotly.newPlot(id, data, layout, config);
};

window.exportPlotlyChartToPdf = function (chartId1, chartId2) {
    const { jsPDF } = window.jspdf;

    const promise1 = Plotly.toImage('intercambios', { format: 'png', width: 650, height: 700*0.65, scale:3 });
    const promise2 = Plotly.toImage('sedes', { format: 'png', width: 650, height: 700*0.65, scale:3   });

    Promise.all([promise1, promise2])
        .then(function ([imgData1, imgData2]) {
            const pdf = new jsPDF();
            pdf.addImage(imgData1, 'PNG', 52, 20, 120, 75);
            pdf.addImage(imgData2, 'PNG', 19, 100, 170, 100);
            pdf.save('charts.pdf');
        });
};