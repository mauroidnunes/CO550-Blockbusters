document.addEventListener( 'DOMContentLoaded', function () {
	var secondarySlider = new Splide( '#secondary-slider', {
        type       : 'fade',
		rewind    : true,
		gap       : 10,
        autoplay: true,
	} ).mount();
	
	var primarySlider = new Splide( '#primary-slider', {
		pagination : false,
		arrows     : false,
		cover      : true,
	} ); // do not call mount() here.
	
	primarySlider.sync( secondarySlider ).mount();
    
} );

document.addEventListener( 'DOMContentLoaded', function () {
	new Splide( '#primary-slider1', {
		gap         : 10,
		cover     : true,
		isNavigation: true,
        pagination : false,
	} ).mount();
} );

document.addEventListener( 'DOMContentLoaded', function () {
	new Splide( '#primary-slider2', {
		gap         : 10,
		cover     : true,
		isNavigation: true,
        pagination : false,
	} ).mount();
} );

document.addEventListener( 'DOMContentLoaded', function () {
	new Splide( '#primary-slider3', {
		gap         : 10,
		cover     : true,
		isNavigation: true,
        pagination : false,
	} ).mount();
} );

document.addEventListener( 'DOMContentLoaded', function () {
	new Splide( '#primary-slider4', {
		gap         : 10,
		cover     : true,
		isNavigation: true,
        pagination : false,
	} ).mount();
} );

document.addEventListener( 'DOMContentLoaded', function () {
	new Splide( '#primary-slider5', {
		gap         : 10,
		cover     : true,
		isNavigation: true,
        pagination : false,
	} ).mount();
} );


document.addEventListener( 'DOMContentLoaded', function () {
	new Splide( '#genre-slider', {
		gap         : 10,
		cover     : true,
		isNavigation: true,
        pagination : false,
	} ).mount();
} );