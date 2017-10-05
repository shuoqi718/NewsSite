$(document).ready(function () {
    $("#DoB").datepicker({
        changeYear: true,
        changeMonth: true,
    });
    $("#DoB").datepicker("option", "dateFormat", "yy-mm-dd");
    $("#PostTime").datepicker({
        changeYear: true,
        changeMonth: true
    });
    $("#PostTime").datepicker("option", "dateFormat", "yy-mm-dd");
    $("#articleTable").DataTable({
        "order": [[2, "asc"]]
    });
    $("#jourTable").DataTable({
        "order": [[4, "asc"]]
    });
    $("#UserTable").DataTable({
        "order": [[2, "asc"]]
    });
});