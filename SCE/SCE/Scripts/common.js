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
    e.stopPropagation();
});

$(".video").click(function (e) {
    $.magnificPopup.open({
        disableOn: 700,
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,

        fixedContentPos: false
    });
});

$(document).ready(function () {
  
});


