window.renderPlotlyBarChart = function (id, xData, yData, title, xSize, ySize) {
    var data = [{
        x: xData,
        y: yData,
        width: 0.3,
        text: yData.map(String),
        textposition: 'outside',
        hoverinfo: 'none',
        type: "bar",
        marker: {
            color: '#03045e'  // Orange color
        }
    }];

    var layout = {
        height: xSize,
        width: ySize,
        yaxis: {
            range: [0, Math.max(...yData)+5] // Ensures y-axis starts at 0 and ends at a value above the highest y value
        },
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

window.renderPlotlyPieChart = function (id, values, labels, title, size) {
    var data = [{
        values: values,
        labels: labels,
        type: 'pie',
        hoverinfo: 'label+value',
        textinfo: "label+percent",
        textposition: "outside",
        texttemplate: "<b>%{label}<br>%{percent}</b>",
        hovertemplate: "%{value} Intercambios %{label}<extra></extra>",
        marker: {
            colors: ['#03045e', '#ff006e'],
            line: {
                color: 'rgba(0,0,0,0)',  // Borde transparente
                width: 0  // Ancho de borde cero
            }
        }
    }];

    var layout = {
        height: size,
        width: size,
        font: { size: 12 },
        showlegend: false,
        margin: { l: 10, r: 10, t: 10, b: 10 },  // Ajustar márgenes
        piecolorway: ['#03045e', '#ff006e']  // Asegurar colores consistentes
    };

    var config = { displayModeBar: false };

    Plotly.newPlot(id, data, layout, config);
};

window.renderPlotlyHorizontalBarChart = function (id, xData, yData, title, xSize, ySize) {
    var data = [{
        x: xData,
        y: yData,
        type: "bar",
        text: xData.map(String),
        textposition: 'outside',
        hoverinfo: 'none',
        orientation: "h",
        marker: {
            color: ['#caf0f8','#ade8f4','#90e0ef','#48cae4','#00b4d8','#0096c7','#0077b6']  // Orange color
        }
    }];

    var layout = {
        height: xSize,
        width: ySize,
        xaxis: {
            range: [0, xData[6]+5] // Ensures y-axis starts at 0 and ends at a value above the highest y value
        },
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