$("#menu-toggle").click(function(e) {
    e.preventDefault();
    $('.tm-left-inner-container').slideToggle();
});

$('#myTabs a').click(function (e) {
    e.preventDefault();
    $(this).tab('show');
});

$(document).ready(function () {

    $("#slider").owlCarousel({

        navigation: false, // Show next and prev buttons
        slideSpeed: 300,
        paginationSpeed: 400,
        singleItem: true,
        autoPlay:true

        // "singleItem:true" is a shortcut for:
        // items : 1, 
        // itemsDesktop : false,
        // itemsDesktopSmall : false,
        // itemsTablet: false,
        // itemsMobile : false

    });

    
});

$(".toggle-ul").click(function (e) {
    $(e.target).parent().children("ul").toggleClass("active-ul");
    return false;
});

$(".send-mail").click(function (e) {
    $.magnificPopup.open({
        items: {
            src: '#send-mail-popup'
        },
        type: 'inline',
        preloader: false,
    });
    return false;
});

$("form.sendMailTo").submit(function (e) {
    var parent = $(e.target);

    var name = parent.find("input[name='name']").val();
    var mail =parent.find("input[name='mail']").val();
    var message = parent.find("textarea[name='message']").val();

    var formData = {
        name: name,
        mail: mail,
        message: message
    };
    $.post("/SendMail", formData).always(function (response) {
        $.magnificPopup.close();
        var modal = response.Success ? "#success" : "#failed";
        $.magnificPopup.open({
            items: {
                src: modal
            },
            type: 'inline',
            preloader: false,
        });
    });
});

$("form").submit(function (e) {
    return false;
});

$(".svidetel").click(function (e) {
    $.magnificPopup.open({
        items: {
            src: '/Content/images/svidetel.jpg'
        },
        type: 'image',
        preloader: false
    });
});
