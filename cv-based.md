// Menu: todo.md

// []- How did you extract excel data into the program?
-
using DocumentFormat.OpenXml library.

// []- How did you implement the file upload functionality for PDFs and Excel?
-
- I implemented the upload using MVC controller action with IFormFile parameter.
- When the user selected a file and submitted, the controller read the file stream.
- For pdf's, I converted the file stream to a byte array and saved it as a BLOB in db.
- For excel i used DocumentFormat.OpenXml library. to read though excel rows.

// []- How did you parse/process the Excel files once uploaded?
-
- After the Excel file was uploaded, I used the DocumentFormat.OpenXml library to read it.
- I opened the file stream, accessed the workbook, and then iterated through the sheets, rows, and cells.


// []- How did you build the dashboard reports? Did you use charts
-
- I built the dashboard using chart.js
- In the backend i created a contoller that queried db and returned the result as JSON.

- $.ajax({
  url: '/Reports/GetRetirementData',   // controller action
  method: 'GET',
  success: function (data) {
    new Chart($("#myChart"), {
      type: 'bar',
      data: {
        labels: data.labels,        // e.g. ["Jan", "Feb", "Mar"]
        datasets: [{
          label: 'Retirements',
          data: data.values,        // e.g. [10, 20, 15]
          backgroundColor: 'rgba(75, 192, 192, 0.6)'
        }]
      }
    });
  }
});


// []- How you transfer data between networks? (using datadump oracle)
- 
- We used Oracle Data Pump (expdp) to export the required tables into a dump file (.dmp) along with a log file.
- Since there was a air gap between the two servers, we use USB stick to transfer the dump file.
- Once the file was moved, we imported it on the target server using (impdp)
