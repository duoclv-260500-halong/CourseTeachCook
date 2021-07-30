// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function(){
    $('.product-slide').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:false,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1.5,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:3,
                margin:15
            },
            1200:{
                items:4,
                margin:15
            }
        }
    });
})

$(document).ready(function(){
    $('#course_pro').owlCarousel({
        items:1,
        pagination: true,
        // navText:["",""],
        responsiveClass:true,
        loop:false,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3,
                margin:15
            }
        }
    });
})

$(document).ready(function(){
    $('#carousel_teacher').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:false,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        navText: [" <img src='/image/icon_prev.png'>","<img src='/image/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:3,
                margin:15
            },
            1200:{
                items:4,
                margin:15
            }
        }
    });
})

$(document).ready(function(){
    $('#bepgiadinh').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:false,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        navText: [" <img src='/image/icon_prev.png'>","<img src='/image/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3,
                margin:15
            }
        }
    });
})

$(document).ready(function(){
    $('#Child').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:false,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3,
                margin:15
            }
        }
    });
})

$(document).ready(function(){
    $('#Cake').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:true,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3 ,
                margin:15
            }
        }
    });
})

$(document).ready(function(){
    $('#Bartender').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:true,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3 ,
                margin:15
            }
        }
    });
})
$(document).ready(function(){
    $('#visual_arts').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:true,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3 ,
                margin:15
            }
        }
    });
})

$(document).ready(function(){
    $('#world_cuisine').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:true,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3 ,
                margin:15
            }
        }
    });
})

function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
  }
  
  // Close the dropdown menu if the user clicks outside of it
  window.onclick = function(event) {
    if (!event.target.matches('.dropbtn')) {
      var dropdowns = document.getElementsByClassName("dropdown-content");
      var i;
      for (i = 0; i < dropdowns.length; i++) {
        var openDropdown = dropdowns[i];
        if (openDropdown.classList.contains('show')) {
          openDropdown.classList.remove('show');
        }
      }
    }
  }

$('.carousel').carousel({
    interval: 5000,
    items:1,
    responsive:{
        0:{
            items:1,
            
        },
        576:{
            items:2,
            
        },
        768:{
            items:2,
           
        },
    }
})

$(document).ready(function(){
    $('#carouselExampleControls').owlCarousel({
        items:1,
        pagination: true,
        navText:["",""],
        responsiveClass:true,
        loop:true,
        margin:30,
        nav:true,
        lazyLoad:true,
        slideBy: 'page',
        // navText: [" <img src='/images/icon_prev.png'>","<img src='/images/icon_next.png'>"],
        responsive:{
            0:{
                items:1,
                margin:15
            },
            576:{
                items:2,
                margin:15
            },
            768:{
                items:2,
                margin:15
            },
            1200:{
                items:3 ,
                margin:15
            }
        }
    });
})

$('.dropdown-submenu > a').on("click", function(e) {
    var submenu = $(this);
    $('.dropdown-submenu .dropdown-menu').removeClass('show');
    submenu.next('.dropdown-menu').addClass('show');
    e.stopPropagation();
});

$('.dropdown').on("hidden.bs.dropdown", function() {
    // hide any open menus when parent closes
    $('.dropdown-menu.show').removeClass('show');
});

