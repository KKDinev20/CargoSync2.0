function initializeRevenueTable(data) {
    // Sort the data by revenue in descending order
    data.sort((a, b) => b.Revenue - a.Revenue);

    // Take the top 3 most profitable products
    var top3Data = data.slice(0, 3);

    var tableBody = document.getElementById('revenueTableBody');
    tableBody.innerHTML = ''; // Clear existing table rows

    top3Data.forEach(entry => {
        var row = `<tr>
                      <td>${entry.ProductName}</td>
                      <td>${entry.Revenue}</td>
                  </tr>`;
        tableBody.innerHTML += row;
    });
}
