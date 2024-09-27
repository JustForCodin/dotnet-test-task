// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function sortTable(columnIndex) {
  const table = document.getElementById("csvTable");
  const rows = Array.from(table.rows).slice(2); // Exclude the first two header rows (filter and sort headers)
  let ascending = true;

  rows.sort((rowA, rowB) => {
    const cellA = rowA.cells[columnIndex].innerText.toLowerCase();
    const cellB = rowB.cells[columnIndex].innerText.toLowerCase();

    // Check if values are numeric and sort accordingly
    if (!isNaN(cellA) && !isNaN(cellB)) {
      return ascending ? cellA - cellB : cellB - cellA;
    }

    return ascending ? (cellA > cellB ? 1 : -1) : (cellA < cellB ? 1 : -1);
  });

  ascending = !ascending;

  rows.forEach(row => table.tBodies[0].appendChild(row));
}

function filterTable(columnIndex) {
  const input = document.getElementById(`filter${['Name', 'Dob', 'Married', 'Phone', 'Salary'][columnIndex]}`).value.toLowerCase();
  const table = document.getElementById("csvTable");
  const rows = Array.from(table.rows).slice(2); // Exclude the first two header rows (filter and sort headers)

  rows.forEach(row => {
    const cell = row.cells[columnIndex].innerText.toLowerCase();
    row.style.display = cell.includes(input) ? "" : "none";
  });
}
