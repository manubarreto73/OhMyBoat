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

window.renderPlotlyPieChart = function (id, values, labels, title, xSize, ySize) {
    var data = [{
        values: values,
        labels: labels,
        type: 'pie',
        hoverinfo: 'label+value',
        textinfo: "label+value+percent",
        textposition: "auto",

        texttemplate: "<b>%{label} <br> %{percent}</b> (%{value})",
        hovertemplate: "%{value}&nbsp;" + "Intercambios %{label}" + "<extra></extra>",
        marker: {
            colors: ['#03045e', '#ff006e']  // Orange color
        }
    }];

    var layoutPie = {
        height: xSize,
        width: ySize,
        font: {
            size: 10  // set the size of the text in the chart
        },
        showlegend: false,
        shapes: [
            {
                type: 'circle',
                xref: 'paper',
                yref: 'paper',
                x0: 0.275,
                y0: 0,
                x1: 0.725,
                y1: 1,
                line: {
                    color: 'black',
                    width: 2
                }
            }
        ],
    };

    var config = {
        displayModeBar: false // This will hide the mode bar
    }

    Plotly.newPlot(id, data, layoutPie, config);
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

window.exportPlotlyChartToPdf = function (fecha, text) {
    const { jsPDF } = window.jspdf;
    let num = 1.1;
    const promise1 = Plotly.toImage('intercambios', { format: 'png', width: 670*num, height: 400*num, scale:3 });
    const promise2 = Plotly.toImage('sedes', { format: 'png', width: 500*num, height: 400*num, scale: 3 });
    const promise3 = Plotly.toImage('tipos', { format: 'png', width: 500*num, height: 400*num, scale: 3 });

    Promise.all([promise1, promise2, promise3])
        .then(function ([imgData1, imgData2, imgData3]) {
            const pdf = new jsPDF();
            let n = 0.18;
            pdf.addImage('Oh_My_Boat_logo_4.jpg', 'JPEG', 4, 0, 20, 20);
            pdf.setFont('times');
            pdf.setFontSize(16);
            pdf.text('Estadísticas de Intercambios', 28, 10);
            pdf.line(28, 14, 95, 14); 
            pdf.addImage(imgData1, 'PNG', 0, 20, 650*n, 400*n);
            pdf.addImage(imgData2, 'PNG', 106, 20, 500*n, 400*n);
            pdf.addImage(imgData3, 'PNG', 62, 100, 500*n, 400*n);
            pdf.setFontSize(10);
            pdf.text('Intercambios concretados y no concretados', 29, 30);
            pdf.text('Intercambios por sede', 134, 30);
            pdf.text('Transportes más intercambiados', 78, 110);
            pdf.text(text, 20, 180);
            pdf.text('Emitido el ' + fecha, 170 , 290);
            pdf.save('OhMyBoat-estadísticas' + fecha + '.pdf');});
        
};