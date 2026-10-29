$(function () {
    $('.btn-send').on('click', function () {
        debugger;
        if (!fnValidation()) {
            return;
        }
        
        $('#frmContactUs').trigger('submit');
    });
});

function fnValidation() {
    var isValid = true;

    // Name
    var name = $('#Name').val().trim();
    if (!name) {
        $('#spnName').text("Name is required!");
        isValid = false;
    } else {
        $('#spnName').text("");
    }

    // Email    
    var email = $('#Email').val().trim();
    var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!email) {
        $('#spnEmail').text("Email is required!");
        isValid = false;
    } else if (!emailPattern.test(email)) {
        $('#spnEmail').text("Invalid email format!");
        isValid = false;
    } else {
        $('#spnEmail').text("");
    }

    // Subject
    var subject = $('#Subject').val().trim();
    if (!subject) {
        $('#Subject').next('span').text("Subject is required!");
        isValid = false;
    } else {
        $('#Subject').next('span').text("");
    }

    // Message
    var message = $('#Message').val().trim();
    if (!message) {
        $('#Message').next('span').text("Message is required!");
        isValid = false;
    } else {
        $('#Message').next('span').text("");
    }

    return isValid;
}

