// JavaScript Document
$(document).ready(function () {

    "use strict";

    /*----------------------------------------------------*/
    /*  Cntact Form Send Function
    /*----------------------------------------------------*/

    $('.contact-form').submit(function (e) {
        e.preventDefault();
        var name = $(".name");
        var email = $(".email");
        var phone = $(".phone");
        var subject = $(".subject");
        var msg = $(".message");
        var flag = false;
        if (name.val() === "") {
            name.closest(".form-control").addClass("error");
            name.focus();
            flag = false;
            return false;
        } else {
            name.closest(".form-control").removeClass("error").addClass("success");
        }
        if (email.val() === "") {
            email.closest(".form-control").addClass("error");
            email.focus();
            flag = false;
            return false;
        } else {
            email.closest(".form-control").removeClass("error").addClass("success");
        }
        if (phone.val() === "") {
            phone.closest(".form-control").addClass("error");
            email.focus();
            flag = false;
            return false;
        } else {
            email.closest(".form-control").removeClass("error").addClass("success");
        }

        if (msg.val() === "") {
            msg.closest(".form-control").addClass("error");
            msg.focus();
            flag = false;
            return false;
        } else {
            msg.closest(".form-control").removeClass("error").addClass("success");
            flag = true;
        }
        const dataString = "name=" + name.val() + "&email=" + email.val() + "&phone=" + phone.val();
        $(".loading").fadeIn("slow").html("Sending the request...");
        $.ajax({
            type: "POST",
            data: dataString,
            url: "/umbraco/api/email/send",
            cache: false,
            success: function (d) {
                $(".form-control").removeClass("success");
                if (d === 'success') // Message Sent? Show the 'Thank You' message and hide the form
                    $('.loading').fadeIn('slow').html('<font color="#48af4b">Thank you! Your request has been submitted successfully.</font>').delay(3000).fadeOut('slow');
                else
                    $('.loading').fadeIn('slow').html('<font color="#ff5607">Something went wrong. Please try again later.</font>').delay(3000).fadeOut('slow');
                document.contactform.reset();
            }
        });
        return false;
    });

    $("#reset").on('click', function () {
        $(".form-control").removeClass("success").removeClass("error");
    });

    /*----------------------------------------------------*/
    /*  Contact Form Validation
    /*----------------------------------------------------*/

    $(".contact-form").validate({
        rules: {
            name: {
                required: true,
                minlength: 1,
                maxlength: 16,
            },
            email: {
                required: true,
                email: true,
            },
            phone: {
                required: true,
                minlength: 5,
            },
        },
        messages: {
            name: {
                required: "We need your name to contact you"
            },
            email: {
                required: "We need your email address to contact you",
                email: "Your email address must be in the format of name@domain.com"
            },
            phone: {
                required: "We need your phone number to contact you"
            }

        }
    });

})



