﻿var dataTable;

$(document).ready(function () {
    loadDataTable(); 
})

//load the table
function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            //define the url to be called 
            "url": "/api/book",
            "type": "GET",
            "datatype": "json"
        },
         //columns that we have to display
        "columns": [
            { "data": "name", "width": "30%" },
            { "data": "author", "width": "30%" },
            { "data": "isbn", "width": "30%" },
            {
                //in last columns we display two columns
                //and need to pass the id
                "data": "id",
                "render": function (data) {
                    return `
                        <div>
                            <a href="/BookList/Edit?id=${data}" class='btn btn-outline-info' style='cursor:pointer; width:100px;' >
                                Edit    
                            </a>
                            <a href="/BookList/Remove?id=${data}" class='btn btn-outline-danger' style='cursor:pointer; width:100px; margin-top:5px;' >
                                Delete  
                            </a>
                        </div> `;
                },"width":"30%"
            }

        ],
        "language": {
            "emptyTable":"no data found"
        },
        "width":"100%"
        
    })
}