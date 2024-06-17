function downloadFileFromStream(filename, contentType, content) {
    var file = new Blob([content], { type: contentType });
    var exportUrl = URL.createObjectURL(file);
    var a = document.createElement('a');
    document.body.appendChild(a);
    a.href = exportUrl;
    a.download = filename;
    a.target = '_self';
    a.click();
    URL.revokeObjectURL(exportUrl);
}
