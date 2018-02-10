function alertModal(title, body, buttonText) {
    var style = 'padding-top:0px;padding-right:20px;padding-bottom:0px;padding-left:20px;';
    var styleFooter = 'padding-top:10px;padding-right:20px;padding-bottom:10px;padding-left:20px;border-top-color:#4EB5A2;';

    var html = '<div class="modal fade" style="display: table;height: 100%;width: 100%;" id="myModal" role="dialog">' +
        '<div class="modal-dialog" style="display: table-cell;vertical-align: middle;">' +
        '<div class="modal-content" style="width: inherit;height: inherit;margin: 0 auto;">' +
        '<div class="modal-header" style="background-color: #4EB5A2;color: white;">' +
        '<button type="button" class="close" style="color: #f5f5f5;opacity: 1;" data-dismiss="modal">&times;</button>' +
        '<i class="fa fa-exclamation-circle" style="font-size: 25px;float:left;"/><h4 class="modal-title" style="margin-left:35px;">' + title + '</h4>' +
        '</div>' +
        '<div class="modal-body" style="' + style + '"><p style="font-size: x-large;">' + body + '</p></div>' +
        '<div class="modal-footer" style="' + styleFooter + '"><button style="background-color: #4EB5A2;color: white;" type="button" class="btn" data-dismiss="modal">' + buttonText + '</button></div>' +
        '</div>' +
        '</div >' +
        '</div >' +
        '<button id="alertButtonModalScript" type="button" class="btn btn-info btn-lg hidden" data-toggle="modal" data-target="#myModal"></button>';
    $("#alertDivForModal").html(html);
    $("#alertButtonModalScript").trigger("click");
}