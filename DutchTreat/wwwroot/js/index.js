$(document).ready(function () {

    var x = 0;
    var s = "";

    console.log("hello");

    var theForm = $("#thorm");
    console.log(theForm);
    theForm.hide();

    var button = $("#buyButton");

    button.on("click", function () {
        console.log("Buying Item");
    })

    var productInfo = $(".product-props li")
    productInfo.on("click", function () {
        console.log("You clicked on:" + $(this).text());
    });

    var $loginToggle=$("#login-toggle")
    var $popupForm = $("#popup-form")

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    });

});


