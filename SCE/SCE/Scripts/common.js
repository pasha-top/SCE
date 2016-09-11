$("#menu-toggle").click(function(e) {
    e.preventDefault();
    $('.tm-left-inner-container').slideToggle();
});

$('#myTabs a').click(function (e) {
    e.preventDefault();
    $(this).tab('show');
});

