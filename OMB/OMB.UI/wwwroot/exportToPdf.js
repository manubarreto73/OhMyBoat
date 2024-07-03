window.exportPlotlyChartToPdf33 = function (fecha, from, to, intercambiosData, sedesData, tiposData) {      // nombre raro porque por alguna razon no me lo agarraba sin nombre asi.
    const { jsPDF } = window.jspdf;
    const pdf = new jsPDF('p', 'pt', 'a4');

    const pageWidth = pdf.internal.pageSize.getWidth();
    const pageHeight = pdf.internal.pageSize.getHeight();
    const margin = 40;

    // Add logo
    const logoWidth = 60; // Adjust as needed
    const logoHeight = 60; // Adjust as needed
    pdf.addImage('Oh_My_Boat_logo_4.jpg', 'JPEG', margin, margin, logoWidth, logoHeight);

    // Add a title to the PDF
    pdf.setFontSize(18);
    pdf.setTextColor(0, 102, 204);
    pdf.text('Reporte de Estadísticas de OhMyBoat!', margin + logoWidth + 20, margin + 30, { align: 'left' });

    // Add the date range below the main title
    pdf.setFontSize(12);
    pdf.setTextColor(0, 0, 0);
    pdf.text(`Desde: ${from} Hasta: ${to}`, margin + logoWidth + 20, margin + 50, { align: 'left' });

    const chartSize = 400;
    const chartWidth = pageWidth - (2 * margin);
    const chartHeight = chartWidth * 0.6;

    const promise1 = Plotly.toImage('intercambios', { format: 'png', width: chartSize, height: chartSize, scale: 3 });
    const promise2 = Plotly.toImage('sedes', { format: 'png', width: chartWidth, height: chartHeight, scale: 2 });
    const promise3 = Plotly.toImage('tipos', { format: 'png', width: chartWidth, height: chartHeight, scale: 2 });

    Promise.all([promise1, promise2, promise3])
        .then(function ([imgData1, imgData2, imgData3]) {
            function addChartWithTitle(title, imgData, y, isCircular = false) {
                pdf.setFontSize(14);
                pdf.setTextColor(0, 0, 0);
                pdf.text(title, pageWidth / 2, y, { align: 'center' });
                if (isCircular) {
                    const xOffset = (pageWidth - chartSize) / 2;
                    pdf.addImage(imgData, 'PNG', xOffset, y + 20, chartSize, chartSize);
                } else {
                    pdf.addImage(imgData, 'PNG', margin, y + 20, chartWidth, chartHeight);
                }
            }

            // Add charts with titles
            addChartWithTitle('Intercambios concretados a no Concretados:', imgData1, margin + 80, true);
            addChartWithTitle('Intercambios por Sede', imgData2, margin + chartSize + 130);

            // Add new page for the third chart
            pdf.addPage();

            addChartWithTitle('Tipos de transporte más intercambiados', imgData3, margin + 30);

            // Add new page for data tables
            pdf.addPage();

            // Function to add data table
            function addDataTable(title, data, startY) {
                pdf.setFontSize(14);
                pdf.setTextColor(0, 0, 0);
                pdf.text(title, pageWidth / 2, startY, { align: 'center' });
                
                let y = startY + 30;
                data.forEach((item, index) => {
                    pdf.setFontSize(12);
                    pdf.text(`${item.label}: ${item.value}`, margin, y);
                    y += 20;
                });
                
                return y + 20; // Return the new Y position
            }

            // Add data tables
            let yPosition = margin;
            yPosition = addDataTable('Datos de Intercambios', intercambiosData, yPosition);
            yPosition = addDataTable('Datos de Sedes', sedesData, yPosition);
            addDataTable('Datos de Tipos de Transporte', tiposData, yPosition);

            // Save the PDF
            pdf.save(`Reporte_Estadísticas_OhMyBoat_${fecha}.pdf`);
        });
};