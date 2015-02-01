body {
    color: #727272;
    font-family: "Open Sans",Helvetica,Arial,sans-serif;
    font-size: 14px;
    line-height: 24px;
}

body.boxed header {
    width: 100%;
}

.wrap {
    overflow: hidden;
}

.page-mask { 
    width: 100%; 
    height: 100%; 
    position: fixed; 
    background: #fff; 
    top:0px; 
    left: 0px; 
    z-index: 99999;
}

.page-loader { 
    width: 44px; 
    height: 44px; 
    text-align: center; 
    line-height: 44px; 
    margin: 23% auto 0 auto; 
    font-size: 12px;
}


.spinner {
  border: 2px solid #eeeeee;
  font-size: 40px;
  width: 1em;
  height: 1em;
  border-radius: .5em;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
  -webkit-animation: spin 1s linear infinite;
  -moz-animation: spin 1s linear infinite;
  animation: spin 1s linear infinite;
}

@-webkit-keyframes spin {
  to {
    -webkit-transform: rotate(360deg);
    -moz-transform: rotate(360deg);
    -ms-transform: rotate(360deg);
    -o-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}

@-moz-keyframes spin {
  to {
    -webkit-transform: rotate(360deg);
    -moz-transform: rotate(360deg);
    -ms-transform: rotate(360deg);
    -o-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}

@keyframes spin {
  to {
    -webkit-transform: rotate(360deg);
    -moz-transform: rotate(360deg);
    -ms-transform: rotate(360deg);
    -o-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}

img {
    max-width: 100%;
}

h1,h2,h3,h4,h5,h6 {
    font-weight: normal;
    color: #666;
    font-family: 'Oswald',sans-serif;
    text-shadow: 0 0 1px rgba(0,0,0,0.01);
}

h1,h2,h3 {
    margin: 0 0 25px;
}

h3 {
    font-size: 22px;
    position: relative;
}

h3.title {
	overflow: hidden;
	line-height:28px;
}

h3.title:after {
    background: url(../img/bg_off.png) repeat;
    content: "";
    height: 5px;
    margin-left: 10px;
    position: absolute;
    top: 12px;
    width: 99%;
}


.our-clients h3.title:after, .service-reasons h3.title:after {
    background: none;
}

.our-clients h3.title, .service-reasons h3.title {
    color: #fff;
}

.our-clients, .service-reasons {
    background: url(../img/img-bg-blur.jpg) 50% 0 no-repeat fixed;
    margin: 0 auto;
    padding: 50px 0;
	background-position: center center;
    background-size: cover;
}

.product-lead {
    background: url(../img/img-blur-lead.jpg) 50% 0 no-repeat fixed;
    margin: 0 auto;
    padding: 50px 0;
    background-position: center center;
    background-size: cover;
}

.client, .service-reasons {
    position: relative;
    overflow: hidden;
}

.our-clients .carousel-controls {
    display: block;
    height: 25px;
    position: absolute;
    right: 0;
    top: 3px;
    width: 83px;
}

ul,li,ol {
    line-height: 24px;
    margin:0;
}

#style-switcher ul, #style-switcher ul li {
    list-style: none;
    padding: 0;
}

a:hover,a:focus {
    text-decoration: none;
    outline: none;
	color: #666;
}

.btn-special,.btn-normal,.btn-small,.btn-large,.comment-des,.steps .popup,.testimonial p,.contact-box {
    border-radius: 3px;
}

/* Header */
#header .main-header {
    min-height: 86px;
    z-index: 9999;
    width: 100%;
    position: relative;
	background:#323B44;
    -webkit-box-shadow: 0 3px 3px -3px rgba(0,0,0,0.2);
    box-shadow: 0 3px 3px -3px rgba(0,0,0,0.2);
}

header .top-bar {
    min-height: 30px;
    background: #25292C;
	border-bottom: 1px solid #414f5a;
    padding: 7px 0;
}

.topnav .navbar-toggle i {
    line-height: 20px;
}

.phone-email {
    padding: 3px 0;
}

.phone-email a {
    margin-right: 20px;
}

.phone-email i.icon-phone {
    font-size: 14px;
}

.phone-email i {
    margin-right: 7px;
}

header .social,footer .social {
    margin-right: 4px;
    line-height: 30px;
}

header #search-form {
    line-height: 30px;
}

footer .social li:last-child,footer .social {
    margin-right: 0 !important;
}

header .social li,footer .social li {
    background-color: #FFF;
    border-radius: 100% 100% 100% 100%;
    -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.6);
    box-shadow: 0 2px 2px 0 rgba(0,0,0,0.6);
    display: inline-block;
    height: 25px;
    margin-right: 5px;
    width: 25px;
    text-align: center;
    background: #fff;
    -webkit-transition: background .5s ease-in-out;
    -moz-transition: background .5s ease-in-out;
    -o-transition: background .5s ease-in-out;
    -ms-transition: background .5s ease-in-out;
    transition: background .5s ease-in-out;
    padding: 1px;
}

header .social i,footer .social i {
    color: #666;
    -webkit-transition: color .5s ease-in-out;
    -moz-transition: color .5s ease-in-out;
    -o-transition: color .5s ease-in-out;
    -ms-transition: color .5s ease-in-out;
    transition: color .5s ease-in-out;
}

#search-form input.search-text-box {
    background-color: #fff;
    background-image: url(../img/search-icon.png);
    background-position: 6px 56%;
    background-repeat: no-repeat;
    border: 0;
    color: transparent;
    font-size: 13px;
    line-height: 18px;
    cursor: pointer;
    -webkit-transition: all .3s ease-in-out;
    -moz-transition: all .3s ease-in-out;
    -o-transition: all .3s ease-in-out;
    -ms-transition: all .3s ease-in-out;
    transition: all .3s ease-in-out;
    -webkit-box-shadow: none;
    box-shadow: none;
    border-radius: 30px;
    width: 25px;
    height: 25px;
    margin: 0;
    padding: 0;
}

#search-form .search-text-box:focus {
    font-size: 13px;
    background-color: #fff;
    width: 170px;
    height: 25px;
    border: 0;
    color: #888;
    cursor: text;
    text-align: left;
    padding: 0 15px 1px 25px;
}

header .main-header {
    display: block;
    position: relative;
    text-align: left;
}

.logo {
    height: 80px;
}

.logo h1 {
    margin: 13px 0;
}

.navbar-fixed-top {
    position: fixed !important;
}

.main-header .navbar-collapse {
    padding-left: 0;
    padding-right: 0;
}

h1 i, h2 i, h3 i, h4 i, h5 i {
    margin-right: 7px;
}

.box-bg {
    background: #FAFAFA;
    border: 1px solid #DDD;
    margin-bottom: 25px;
    padding: 10px 15px;
}

/* Breadcrumbs */
.breadcrumb-wrapper, .login-page, .register-page  {
    background: #FAFAFA;
    border: 1px solid #DDD;
    -webkit-box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
	
	/* Safari 4-5,Chrome 1-9 */ 
	background:-webkit-gradient(linear,0% 0%,0% 100%,from(#f8f8f8),to(#fafafa));
	
	/* Safari 5.1,Chrome 10+*/ 
	background:-webkit-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Firefox 3.6+*/ 
	background:-moz-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* IE 10 */ 
	background:-ms-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Opera 11.10+*/ 
	background:-o-linear-gradient(top,#f8f8f8,#fafafa);
}

h2.title {
    font-size: 26px;
    line-height: 40px;
    margin: 20px 0;
}

.breadcrumbs {
    margin: 24px 0;
}

.breadcrumbs ul li {
    display: inline-block;
    line-height: 24px;
    font-size: 13px;
    color: #9e9e9e;
    margin: 0 0 0 5px;
}

.breadcrumbs ul li a {
    color: #898989;
    font-weight: 600;
}

.breadcrumbs ul li:first-child {
    margin-left: 2px !important;
}

.breadcrumbs ul li:nth-child(2):before,.breadcrumbs ul li:first-child:before {
    content: " ";
    margin: 0;
}

.breadcrumbs ul li:before {
    color: #9e9e9e;
    content: "\f105";
    font-family: FontAwesome;
    font-size: 12px;
    margin: 0 9px 0 0;
}
/* Slider */
.fullwidthbanner-container {
    width: 100% !important;
    position: relative;
    max-height: 470px !important;
    overflow: hidden;
    background-image: url(../img/loader.gif);
    background-repeat: no-repeat;
    background-position: 50%;
    padding: 0;
    visibility: hidden;
}

.tp-leftarrow.default,.nivo-prevNav {
    border-bottom-right-radius: 3px;
    border-top-right-radius: 3px;
    z-index: 100;
    cursor: pointer;
    position: relative;
    background: #898989;
    padding-top: 20px !important;
    width: 45px;
    height: 60px;
    text-align: center;
    -webkit-transition: background .5s ease-in-out;
    -moz-transition: background .5s ease-in-out;
    -o-transition: background .5s ease-in-out;
    -ms-transition: background .5s ease-in-out;
    transition: background .5s ease-in-out;
    -ms-filter: progid:DXImageTransform.Microsoft.Alpha(Opacity=0);
    filter: alpha(opacity=0);
    opacity: 0;
    -khtml-opacity: 0;
    -moz-opacity: 0;
    visibility: visible;
}

.tp-leftarrow.default:before,.nivo-prevNav:before {
    content: "\f053";
    font-family: FontAwesome;
    font-size: 24px;
    font-style: normal;
    font-weight: 400;
    color: #fafafa;
    text-align: center;
    visibility: visible;
}

.tp-rightarrow.default,.nivo-nextNav {
    border-bottom-left-radius: 3px;
    border-top-left-radius: 3px;
    z-index: 100;
    cursor: pointer;
    position: relative;
    background: #898989;
    padding-top: 20px !important;
    width: 45px;
    height: 60px;
    text-align: center;
    -webkit-transition: background .5s ease-in-out;
    -moz-transition: background .5s ease-in-out;
    -o-transition: background .5s ease-in-out;
    -ms-transition: background .5s ease-in-out;
    transition: background .5s ease-in-out;
    -ms-filter: progid:DXImageTransform.Microsoft.Alpha(Opacity=0);
    filter: alpha(opacity=0);
    opacity: 0;
    -khtml-opacity: 0;
    -moz-opacity: 0;
    visibility: visible;
}

.tp-rightarrow.default:before,.nivo-nextNav:before {
    content: "\f054";
    font-family: FontAwesome;
    font-size: 24px;
    font-style: normal;
    font-weight: 400;
    color: #fafafa;
    text-align: center;
    visibility: visible;
}

.nivo-caption h2 {
	margin:0;
	line-height:60px;
}


/* Buttons */
.btn:hover,.btn:focus {
    color: #fff;
}

.btn-pad {
    margin: 7px;
}

.btn-grey {
    color: #515151 !important;
    text-shadow: -1px 1px 0px #fff;
    outline: 0;
    white-space: nowrap;
    word-wrap: normal;
    vertical-align: middle;
    cursor: pointer;
    background-color: #fff;
    background-image: -webkit-linear-gradient(top, rgb(255,255,255) 2%, rgb(240,240,240) 2%, rgb(222,222,222) 100%);
    background-image: -moz-linear-gradient(top, rgb(255,255,255) 2%, rgb(240,240,240) 2%, rgb(222,222,222) 100%);
    background-image: -o-linear-gradient(top, rgb(255,255,255) 2%, rgb(240,240,240) 2%, rgb(222,222,222) 100%);
    background-image: -ms-linear-gradient(top, rgb(255,255,255) 2%, rgb(240,240,240) 2%, rgb(222,222,222) 100%);
    background-image: linear-gradient(top, rgb(255,255,255) 2%, rgb(240,240,240) 2%, rgb(222,222,222) 100%);
    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#ffffff', endColorstr='#dedede',GradientType=0 );
    border: 1px solid #969696;
    -webkit-box-shadow: 0 1px 2px rgba(144, 144, 144, 0.4);
    box-shadow: 0 1px 2px rgba(144, 144, 144, 0.4);
    text-shadow: 0 1px 1px rgba(255, 255, 255, 0.75) !important;
}

.btn-grey:hover {
    background: -webkit-linear-gradient(#f8f8f8,#ddd);
    background: -moz-linear-gradient(#f8f8f8,#ddd);
    background: -o-linear-gradient(#f8f8f8,#ddd);
    background: -ms-linear-gradient(#f8f8f8,#ddd);
    background: linear-gradient(#f8f8f8,#ddd);
}

.btn-color,.btn-grey {
    -webkit-transition: all .5s ease-in-out !important;
    -moz-transition: all .5s ease-in-out !important;
    -o-transition: all .5s ease-in-out !important;
    -ms-transition: all .5s ease-in-out !important;
    transition: all .5s ease-in-out !important;
}

.btn-color {
    color: #fff !important;
    text-shadow: 0 1px #555 !important;
}

.btn-special {
    border-radius: 4px;
}

.btn-special {
    padding: 15px 30px;
    text-transform: uppercase;
    letter-spacing: 1px;
    font-weight: 700;
    outline: none;
    -webkit-transition: all .5s ease-in-out;
    -moz-transition: all .5s ease-in-out;
    -o-transition: all .5s ease-in-out;
    -ms-transition: all .5s ease-in-out;
    transition: all .5s ease-in-out;
}

.btn-normal {
    display: inline-block;
    cursor: pointer;
    font-size: 16px;
    padding: 12px 30px;
}

.btn-small {
    display: inline-block;
    cursor: pointer;
    font-size: 14px;
    padding: 7px 20px;
}

.btn-large {
    display: inline-block;
    cursor: pointer;
    font-size: 20px;
    padding: 17px 50px;
}

/* Main Content */
#main {
    background-color: #fff;
	padding: 0 0 60px;
}

.home #main, .home-3 #main, .home-4 #main, .page-services #main, .about #main {
	padding:0;
}


/*Blog page*/

.page article.post {
    border-bottom: none;
}

.post-header h3.content-title {
    text-align: left !important;
    margin-bottom: 15px;
}


.blog-entry-meta {
    font-size: 0;
}

.blog-entry-meta-date {
    display: inline-block;
    margin-right: 25px;
    margin-bottom: 10px;
    font-size: 14px;
    vertical-align: top;
}

.blog-entry-meta-author {
    display: none;
    margin-right: 15px;
    margin-bottom: 10px;
    font-size: 14px;
    vertical-align: top;
}

.blog-entry-meta-tags {
    display: none;
    margin-right: 25px;
    margin-bottom: 10px;
    font-size: 14px;
    vertical-align: top;
}

.blog-entry-meta-comments {
    display: none;
    margin-bottom: 10px;
    font-size: 14px;
    vertical-align: top;
}

ol.commentlist, ol.commentlist li {
    list-style: none;
    padding: 0;
}

.blog-entry-meta i {
	margin-right: 4px;
}



.blog.meta_author .blog-entry-meta-author {
    display: inline-block;
}

.blog.meta_tags .blog-entry-meta-tags {
    display: inline-block;
}

.blog.meta_comments .blog-entry-meta-comments {
    display: inline-block;
}

.blog.meta_authortags .blog-entry-meta-author,.blog.meta_authortags .blog-entry-meta-tags {
    display: inline-block;
}

.blog.meta_authorcomments .blog-entry-meta-author,.blog.meta_authorcomments .blog-entry-meta-comments {
    display: inline-block;
}

.blog.meta_tagscomments .blog-entry-meta-tags,.blog.meta_tagscomments .blog-entry-meta-comments {
    display: inline-block;
}

.blog-entry-meta-author,.blog-entry-meta-tags,.blog-entry-meta-comments {
    display: inline-block;
}

.post-content {
    padding-bottom: 10px;
}

.blog-small article .post-image {
	float:left;
	width: 43%;
	margin-bottom:25px;
}

.blog-small article .post-content-wrap {
	float:left;
	width: 50%;
	margin:0 0 0 4%;
}

.post-date a.date {
    background: none repeat scroll 0 0 #fafafa;
    display: block;
    float: left;
    margin-right: 20px;
    padding: 10px 0 0;
    text-align: center;
    text-decoration: none;
    width: 55px;
	border-radius:2px;
}

.post-date a.date strong {
    color: #1889C1;
    display: block;
    font-size: 27px;
    font-weight: normal;
    margin-bottom: 10px;
}

.post-date a.date i {
    background-color: #1889C1;
    border-top: 1px solid #F3F3F3;
    color: #FFFFFF;
    display: block;
    font-size: 11px;
    font-style: normal;
}

.blog-small .blog-entry-meta-author, .blog-small .blog-entry-meta-tags, .blog-small .blog-entry-meta-comments {
	font-size:11px;
}

/* Sidebar */
.sidebar ul.slide li {
    padding-left: 0;
    -webkit-transition: all .5s ease-in-out;
    -moz-transition: all .5s ease-in-out;
    -o-transition: all .5s ease-in-out;
    -ms-transition: all .5s ease-in-out;
    transition: all .5s ease-in-out;
}

.sidebar ul.slide li:hover {
    padding-left: 5px;
    -webkit-transition: all .5s ease-in-out;
    -moz-transition: all .5s ease-in-out;
    -o-transition: all .5s ease-in-out;
    -ms-transition: all .5s ease-in-out;
    transition: all .5s ease-in-out;
}

.sidebar p {
    text-align: left !important;
    margin: 0 0 2px;
}

.sidebar .widget, .widget {
    margin-bottom: 35px;
}

.widget ul {
    list-style: none;
    padding: 0;
}

.search-input {
    height: 38px !important;
    width: 218px;
}

/* Tabs */
#horizontal-tabs {
	margin-bottom:30px;
}

#horizontal-tabs ul.tabs li {
    background: #fafafa;
    border-right: 1px solid #ddd;
    border-top: 2px solid #666;
    cursor: pointer;
    float: left;
    font-size: 15px;
    padding: 12px;
}

#horizontal-tabs ul.tabs li.current {
    border-bottom: 1px solid #fff;
    background: none;
    cursor: default;
}

#horizontal-tabs ul.tabs {
    border-left: 1px solid #ddd;
    overflow: hidden;
	border-radius:2px;
	list-style:none;
	margin:0;
	padding:0;
}

#horizontal-tabs .contents {
    border: 1px solid #ddd;
    margin-top: -1px;
	border-radius:2px;
}

#horizontal-tabs .tabscontent.no-padding {
    padding-left: 0;
    padding-right: 0;
}

#horizontal-tabs .tabscontent {
    display: none;
    overflow: hidden;
    padding: 20px 20px 0;
}

.tabs ul.posts li {
    margin-bottom: 15px;
    padding-bottom: 10px;
    overflow: hidden;
    border-bottom: 1px solid #f8f8f8;
}

.tabs ul.posts li img {
    height: 68px;
    width: 68px;
    -webkit-transition: all .4s ease-in 0;
    -moz-transition: all .4s ease-in 0;
    -o-transition: all .4s ease-in 0;
    -ms-transition: all .4s ease-in 0;
    transition: all .4s ease-in 0;
    float: left;
}

.recent-post-img {
    margin: 0 13px 5px 0;
}

.sidebar .testimonials-title h3 {
    margin: 0 0 20px !important;
}

.category ul li:before {
    content: "\f105";
    font-family: FontAwesome;
    font-size: 16px;
    font-style: normal;
    font-weight: 400;
    padding-right: 10px;
}

.widget.category ul li {
    margin-bottom: 7px;
    border-bottom: 1px solid #F8F8F8;
    padding: 3px 0;
}

.widget .ads-img img {
    margin-bottom: 30px;
	max-width: 100%;
}


/* Author Info */
.about-author {
    margin-top: 30px;
}

.author-content {
    padding: 20px;
}

.author-content .avatar {
    float: left;
    margin: 0 20px 0 0;
	
}

.avatar {
	border: 1px solid #ddd;
	padding:4px !important;
	border-radius: 100%;
}

.avatar img {
	border-radius: 100%;
}

.author-content .data {
    margin: -10px 0 0;
}


/* Comments Section */
.comments-sec {
    float: left;
    width: 100%;
    margin: -5px 0 25px;
}

ol.commentlist li {
    float: left;
    padding: 10px 0 15px;
}

ol.commentlist {
    float: left;
    width: 100%;
    margin: 0;
}

ol li ol.childlist {
    float: right;
    width: 86%;
    margin: 0;
}

ol.commentlist li ol.childlist li:first-child {
    padding: 25px 0 0;
}

ol.commentlist li:first-child {
    margin: 0 0 7px;
    padding: 25px 0 0;
}

.avatar img {
    float: left;
    max-width: 70px;
}

.comment-des p {
    line-height: 23px;
    margin: 0;
}

.comment-des {
    float: left;
    background: #fafafa;
	border: 1px solid #ddd;
    color: #888;
    -webkit-box-shadow: :inset 0 -1px 0 0 rgba(0,0,0,0.06);
    box-shadow: :inset 0 -1px 0 0 rgba(0,0,0,0.06);
    margin: -70px 0 0 100px;
    padding: 19px 22px 22px;
}



.comment:before {
    position: absolute;
    display: block;
    content: "";
    margin-left: 93px;
    margin-top: 25px;
    width: 15px;
    height: 15px;
    background-color: #fafafa;
    border: 1px solid #ddd;
    -webkit-transform: rotate(45deg);
    -moz-transform: rotate(45deg);
    -o-transform: rotate(45deg);
    -ms-transform: rotate(45deg);
    transform: rotate(45deg);
    border-right: none;
    border-top: 0;
    z-index: 1;
}

.comment-des strong {
    float: left;
    padding-right: 5px;
    font-size: 14px;
    color: #666;
}

.comment-des span {
    float: left;
    color: #999;
}

.comment-by {
    float: left;
    width: 100%;
    padding-bottom: 8px;
    padding-top: 5px;
}

.comment-by span.reply {
    float: right;
    display: inline;
}

.comment-by span.reply a {
    float: right;
    height: 17px;
    margin-left: 5px;
    font-weight: 400;
    color: #999;
}

.comment-by span.reply a i {
    color: #bbb;
    -webkit-transition: all .1s ease-in-out;
    -moz-transition: all .1s ease-in-out;
    -o-transition: all .1s ease-in-out;
    -ms-transition: all .1s ease-in-out;
    transition: all .1s ease-in-out;
}

.comment-by span.reply a:hover,.comment-by span.reply a:hover i {
    color: #a0a0a0;
}

.comment-by span.date {
    color: #999;
    float: left;
    font-weight: 300;
    margin: 0 0 0 2px;
    padding: 0 0 0 9px;
}

.reply label {
    margin: 0 0 4px;
}

.reply label span {
    color: #e24747;
}

.reply input {
    margin: 0 0 20px;
}

.reply textarea {
    min-width: 97.5%;
    min-height: 180px;
    -webkit-resize: vertical;
    -moz-resize: vertical;
    -webkit-resize: vertical;
    -moz-resize: vertical;
    resize: vertical;
    margin: 0 0 18px;
}


/* Slogan Area */
.slogan {
    min-height: 100px;
    background: #fafafa;
    width: 100%;
    border-top: 1px solid #DDD;
    border-bottom: 1px solid #DDD;
    -webkit-box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
}

.slogan-content {
    padding: 25px 0;
}

.slogan-title {
    display: inline-block;
    margin: 10px 0;
}

.page-services .slogan-content {
    padding: 40px 0;
}

.page-services .get-started  {
	padding-top: 15px;
}

.get-started {
    padding-top: 1px;
	vertical-align:middle;
}

/* Product Lead Section*/

.app-service, .app-service h3, .app-service h4 {
    color:#fff;
}

/* Main Content Boxes */
.main-content,.content {
    padding: 60px 0 0;
}

.home-3 .main-content, .home-4 .main-content {
	margin: 45px 0 40px;
	padding:0;
}

.main-content {
	margin: 45px 0 35px;
}

div.content-box {
    clear: both;
}

div.content-box div.content-box-info {
    padding-left: 115px;
}

div.content-box.big {
	padding:0 7% 30px;
	border-radius: 3px;
	background:#fff;
	-webkit-transition: background .5s ease-in-out;
    -moz-transition: background .5s ease-in-out;
    -o-transition: background .5s ease-in-out;
    -ms-transition: background .5s ease-in-out;
    transition: background .5s ease-in-out;
}


div.content-box.big .ch-info-wrap {
	margin: -42px auto 35px;
	position:relative;
	left:auto;
	top:auto;
}

div.content-box.big:hover {
	background: #fafafa;
}

div.content-box.big div.content-box-info {
    padding-left: 0;
	text-align:center;
	margin:25px 0 0;
}

div.content-box.big div.content-box-info p {
	text-align:center;
	margin-top: 25px;
}

.service-reasons div.content-box.big {
	transition:none;
	margin-top: 30px;
	border: 1px solid #fff;
}

.main-content h3 {
    color: #666;
    line-height: 32px;
    margin: 0 0 5px;
}

.main-content p,.content p {
    text-align: left;
}


/* Box border and background */

.author-content, div.content-box.big, #cn-tabs .service, .comment-des, .contact-box {
	border-style:solid;
	border-width: 1px 1px 3px;
	border-color: #ddd;
	background: #fafafa;
	
	
	/* Safari 4-5,Chrome 1-9 */ 
	background:-webkit-gradient(linear,0% 0%,0% 100%,from(#f8f8f8),to(#fafafa));
	
	/* Safari 5.1,Chrome 10+*/ 
	background:-webkit-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Firefox 3.6+*/ 
	background:-moz-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* IE 10 */ 
	background:-ms-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Opera 11.10+*/ 
	background:-o-linear-gradient(top,#f8f8f8,#fafafa);
}



/*Graph Style*/

ul.graph-container {
	margin-left:10em;
}


/*************************************
 *   Bars Fill                       *
 * Just an example of filling 3 bars *
 *************************************/
.graph-container > li:nth-child(1) .bar-inner { height: 25%; bottom: 0; }
.graph-container > li:nth-child(2) .bar-inner { height: 50%; bottom: 0; }
.graph-container > li:nth-child(3) .bar-inner { height: 75%; bottom: 0; }
.graph-container > li:nth-child(4) .bar-inner { height: 85%; bottom: 0; }
.graph-container > li:nth-child(5) .bar-inner { height: 90%; bottom: 0; }



/* Portfolio */
ul#filters {
    list-style: none;
    padding: 0;
}

.portfolio-single .work-title h3 {
    margin-bottom: 20px !important;
}

.portfolio-wrap .item {
    width: 24.99%;
}

.item .item-inner,.post-image {
    margin-bottom: 30px;
    overflow: hidden;
    position: relative;
    border-radius: 2px;
}

.post-image, .img-content {
	padding: 4px;
	border: 1px solid #ddd;
	background: url(../img/bg_off.png) repeat;
}

.img-content {
	float: left;
	margin: 5px 20px 20px 0;
}

.img-content img {
	width: 100%;
}

.post-image a {
	display:block;
	position:relative;
}

.post-image .nivoSlider a {
	position: absolute !important;
}

.portfolio .item .portfolio-item {
	margin-bottom: 30px;
}

/*Project details*/

.project_details span {
    border-bottom: 1px solid #E3E3E3;
    color: #454545;
    float: left;
    font-size: 14px;
    font-weight: bold;
    margin: 0;
    padding: 5px 0;
    width: 100%;
}

.project_details strong {
    float: left;
    margin: 0;
    padding: 0;
    width: 40%;
}

.project_details em {
    float: left;
    font-style: normal;
    margin: 0;
    padding: 0;
    width: 60%;
}

.project_details span a {
    background-color: #fafafa;
    border-radius: 3px;
	border:1px solid #ddd;
    color: #666;
    font-size: 14px;
    font-style: normal;
    font-weight: normal;
    margin: 0 0 5px 5px;
    padding: 3px 10px;
	display:inline-block;
}

.recentworks {
    background: #fafafa;
    border-top: 1px solid #DDD;
    border-bottom: 1px solid #DDD;
    padding: 60px 0;
    -webkit-box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
	
	/* Safari 4-5,Chrome 1-9 */ 
	background:-webkit-gradient(linear,0% 0%,0% 100%,from(#f8f8f8),to(#fafafa));
	
	/* Safari 5.1,Chrome 10+*/ 
	background:-webkit-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Firefox 3.6+*/ 
	background:-moz-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* IE 10 */ 
	background:-ms-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Opera 11.10+*/ 
	background:-o-linear-gradient(top,#f8f8f8,#fafafa);
}


/* Circular navigation */
.cn-wrapper {
    width: 26em;
    height: 26em;
    position: relative;
    z-index: 10;
    bottom: 0;
    left: 50%;
	overflow: hidden;
    margin-left: -185px;
    border: 1px solid #ddd;
    -webkit-transition: all .3s ease;
    -moz-transition: all .3s ease;
    -o-transition: all .3s ease;
    -ms-transition: all .3s ease;
    transition: all .3s ease;
}

.cn-wrapper:after {
    content: "";
    display: block;
    height: 8px;
    width: 8px;
    position: absolute;
    top: 50%;
    left: 50%;
    margin-top: -4px;
    margin-left: -4px;
    border-radius: 50%;
    z-index: 11;
}

.cn-wrapper li {
    position: absolute;
    font-size: 1.5em;
    width: 10em;
    height: 10em;
    overflow: hidden;
    -webkit-transform-origin: 100% 100%;
    -moz-transform-origin: 100% 100%;
    -o-transform-origin: 100% 100%;
    -ms-transform-origin: 100% 100%;
    transform-origin: 100% 100%;
    border: 1px solid #fff;
    -webkit-transition: all 1s ease;
    -moz-transition: all 1s ease;
    -o-transition: all 1s ease;
    -ms-transition: all 1s ease;
    transition: all 1s ease;
}

.cn-wrapper li a {
    display: block;
    font-size: 1.2em;
    height: 13.5em;
    width: 13.5em;
    position: absolute;
    bottom: -6.75em;
    right: -6.75em;
	overflow: hidden;
    text-decoration: none;
    -webkit-transition: background-color .3s ease, -webkit-transform .8s ease;
    -moz-transition: background-color .3s ease, -moz-transform .8s ease;
    -o-transition: background-color .3s ease, -o-transform .8s ease;
    -ms-transition: background-color .3s ease, -ms-transform .8s ease;
    transition: background-color .3s ease, transform .8s ease;
}

.cn-wrapper li a:hover,.cn-wrapper li a.active {
    background-color: #fafafa;
    -webkit-transition: background-color .5s ease;
    -moz-transition: background-color .5s ease;
    -o-transition: background-color .5s ease;
    -ms-transition: background-color .5s ease;
    transition: background-color .5s ease;
}

.cn-wrapper span {
    font-size: 1.3em;
}


/*Cirular Navigation Content*/
.cn-content {
    -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=0)";
    filter: alpha(opacity=0);
    opacity: 0;
}

.circular-nav {
	overflow:hidden;
}

#cn-tabs .service {
	display:none;
	overflow:hidden;
	background: #fafafa;
    padding: 15px 25px;
    border-radius: 2px;
}

.cn-content {
    
	overflow:hidden;
	
}

.cn-content p {
    z-index: 9999;
}

#cn-tabs .service:before {
    position: absolute;
    display: block;
    content: "";
    top: 44%;
    right: -3px;
    width: 35px;
    height: 35px;
    background-color: #fafafa;
    border: 1px solid #ddd;
    -webkit-transform: rotate(45deg);
    -moz-transform: rotate(45deg);
    -o-transform: rotate(45deg);
    -ms-transform: rotate(45deg);
    transform: rotate(45deg);
    border-left: none;
    border-bottom: 0;
    z-index: 1;
}


/* Carousel Controls */

a.prev.disabled,a.next.disabled {
    cursor: default;
}

.carousel-controls-color {
    background: #fff;
}

.carousel-controls a.next {
    right: 15px;
    position: absolute;
}

.carousel-controls a.prev {
    right: 45px;
    position: absolute;
}

a.prev,a.next {
    width: 25px;
    height: 25px;
    display: block;
    cursor: pointer;
    background: #323B44;
    color: #fafafa;
    font-size: 20px;
    text-align: center;
    text-decoration: none;
}

a.next {
    padding-left: 3px;
}

a.prev.disabled,a.next.disabled {
    display: block;
    cursor: default;
    background: #323B44;
    color: #fafafa;
    font-size: 20px;
    text-align: center;
}


/* Testimonials */
.testimonial p {
    background: #fafafa;
    font-weight: 500;
    margin: 0;
    padding: 27px 25px;
	border: 1px solid #ddd;
	
	/* Safari 4-5,Chrome 1-9 */ 
	background:-webkit-gradient(linear,0% 0%,0% 100%,from(#f8f8f8),to(#fafafa));
	
	/* Safari 5.1,Chrome 10+*/ 
	background:-webkit-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Firefox 3.6+*/ 
	background:-moz-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* IE 10 */ 
	background:-ms-linear-gradient(top,#f8f8f8,#fafafa);
	
	/* Opera 11.10+*/ 
	background:-o-linear-gradient(top,#f8f8f8,#fafafa);
}

.our-clients .testimonial p, .our-clients .testimonials-arrow {
	border: none;
}
	

.testimonials-arrow {
    display: block;
    content: "";
    margin-top: -7px;
    margin-left: 45px;
    width: 14px;
    height: 14px;
    background-color: #fafafa;
    -webkit-transform: rotate(45deg);
    -moz-transform: rotate(45deg);
    -o-transform: rotate(45deg);
    -ms-transform: rotate(45deg);
    transform: rotate(45deg);
    margin-bottom: 10px;
	border-bottom: 1px solid #ddd;
	border-right: 1px solid #ddd;
    border-top: 0;
}

.testimonial .author {
    margin: 0px 0 0 19px;
}

.testimonial-image {
    float: left;
    height: 70px;
    position: relative;
    width: 70px;
}

.testimonial-image img {
    border-radius: 50px;
    height: 70px !important;
    width: 70px !important;
	border:1px solid #ddd;
	padding:4px;
}

.our-clients .testimonial-image img {
	border:none;
	padding:0;
}

.our-clients .testimonial-author-info {
    color: #ddd;
}

.testimonial-author-info {
    padding: 10px 0 0 90px;
    color: #666;
}

.testimonial-author-info a {
	display:block;
}

.our-clients .testimonial-author-info a {
    color: #fff;
}

span.color {
    font-size: 14px;
    font-weight: 700;
}


/* Footer */
#footer ul, #footer li {
	padding:0;
	margin:0;
}

.footer-top {
    background: #323B44;
	border-bottom: 1px solid #414f5a;
    color: #A1A1A1;
    padding: 50px 0;
}

.footer-bottom {
    background: #25292C;
    color: #888;
    line-height: 30px;
    padding: 15px;
}

.social-icons-footer-bottom {
    float: right;
    margin: 6px 0 0;
}

.social-icons-footer-bottom li {
    display: inline;
    float: left;
    margin-right: 7px !important;
    list-style: none;
    -webkit-transition: all .2s ease-in-out 0;
    -moz-transition: all .2s ease-in-out 0;
    -o-transition: all .2s ease-in-out 0;
    -ms-transition: all .2s ease-in-out 0;
    transition: all .2s ease-in-out 0;
}

.social-icons-footer-bottom li i {
    display: inline-block;
    font-family: FontAwesome;
    font-size: 13px;
    font-style: normal;
    font-variant: normal;
    font-weight: 400;
    line-height: 16px;
    padding-top: 0;
    text-align: center;
    text-decoration: inherit;
    text-transform: none;
}

.scrollup {
    width: 40px;
    height: 40px;
    -ms-filter: progid:DXImageTransform.Microsoft.Alpha(Opacity=80);
    filter: alpha(opacity=80);
    opacity: 0.8;
    position: fixed;
    bottom: 100px;
    right: 15px;
    display: none;
    text-align: center;
    color: #fafafa;
    font-size: 28px;
    background: #9e9e9e;
    z-index: 9999;
}

.scrollup i {
    line-height: 38px;
}

a.scrollup:hover i,a.scrollup:focus i {
    text-decoration: none;
    color: #fafafa;
    outline: none;
}

#tweets li:before {
    color: #727272;
    content: "\f099";
    float: left;
    font-family: FontAwesome;
    font-size: 16px;
    margin: 0 0 0 -28px;
}

#tweets li {
    line-height: 24px;
    margin: 0 0 15px;
    padding: 0 0 0 28px;
}

#tweets .content {
    padding-top: 0;
    margin-bottom: 5px;
}

#flickrfeed li {
	float:left;
	margin:5px 5px 0 0;
}

.contact-us {
    margin: 15px 0 0;
    background: url("../img/contact-map.png") no-repeat center bottom;
}

.business-hour i {
    margin-right: 5px;
}

footer .contact-us a {
    color: #fff !important;
}

.contact-us .icon-map-marker {
    font-size: 16px;
}

.contact-us li i {
    color: #666;
    float: left;
    margin: 4px 0 0;
}

.contact-us p {
    line-height: 24px;
    margin-left: 20px;
    margin-top: -2px;
}

.contact-us li p strong {
    color: #727272;
    float: left;
    font-weight: 600;
    margin: 0 5px 5px 0;
}

.contact-pad {
    padding-bottom: 20px;
}

.subscribe-btn {
    height: 38px;
    background-image: none;
    color: #fff;
    text-shadow: none;
    font-size: 14px;
    border: none;
	text-shadow: 0 1px #555555 !important;
}

.subscribe {
    height: 38px !important;
    width: 100%;
}

#not-found {
    margin: 60px 0 45px;
}

#not-found h2 {
    font-size: 200px;
    font-weight: 500;
    letter-spacing: -5px;
    line-height: 210px;
    text-align: center;
}

#not-found p {
    color: #9e9e9e;
    font-size: 32px;
    line-height: 48px;
    text-align: center;
}

#not-found i {
    color: #F03;
    font-size: 210px;
    position: relative;
    top: -12px;
}

.back-home p {
	text-align:center !important;
	margin: 0 auto;
}

.back-home .search-form {
	width: 290px;
	margin:30px auto 0;
}

.sitemap {
	margin-bottom:15px;
}

.hero {
    background: none repeat scroll 0 0 #FAFAFA;
    border-left: 4px solid #DDD;
    color: #666;
    font-size: 16px;
    margin: 20px 0;
    padding: 18px;
}

/* Services */
ul.why {
	
	list-style:none;
	padding:0;
	margin:0;
}

ul.why li {
    margin: 7px 0;
}

ul.why li:before {
    content: "\f00c";
    font-family: FontAwesome;
    position: relative;
    color: #fff;
    background: #666;
    border-radius: 100%;
    margin: 0 7px 0 0;
    padding: 3px;
}

.services-big div.content-box div.content-box-icon {
	border: 1px solid #ddd;
    background: url(../img/bg_off.png) repeat;
    border-radius: 2px;
    display: block;
    float: none;
    position: relative;
	padding: 4px;
}

.services-big .content-box-icon span {
    z-index: 4;
    display: block;
    width: 130px;
    height: 130px;
    border-radius: 130px;
    background-color: #666;
}

.services-big .content-box-icon i {
    color: #fff;
    float: left;
    font-size: 48px;
    line-height: 130px;
    left: 34%;
    position: relative;
    z-index: 5;
}

.services-big div.content-box div.content-box-info {
    padding-left: 0;
}

.services-big h4 {
    margin: 20px 0;
}

.services-big img {
	
	width:100%;
}


/* Common Elements */
.divider {
    margin: 60px 0;
}

.blog-divider {
	margin:35px 0;
	background: url(../img/bg_off.png) repeat;
    content: "";
    height: 5px;
}

.top-pad {
    margin-top: 25px;
}

.no-divider {
    margin: 0;
}

.bottom-pad {
    margin-bottom: 60px;
}

.bottom-pad-small {
    margin-bottom: 30px;
}

.no-bottom-pad {
    margin-bottom: 0 !important;
    padding-bottom: 0 !important;
}

/* Form */

input.form-control, textarea.form-control { 
	border: solid 1px #CCC;
	background: -webkit-gradient(linear, left top, left 25, from(#FFFFFF), color-stop(4%, #EEEEEE), to(#FFFFFF)) !important;
	background: -moz-linear-gradient(top, #FFFFFF, #EEEEEE 1px, #FFFFFF 25px) !important;
	box-shadow: rgba(0,0,0, 0.1) 0px 0px 8px !important;
	-moz-box-shadow: rgba(0,0,0, 0.1) 0px 0px 8px !important;
	-webkit-box-shadow: rgba(0,0,0, 0.1) 0px 0px 8px !important;
}


input:hover, textarea:hover,
input:focus, textarea:focus { 
	border-color: #C9C9C9; 
	-webkit-box-shadow: rgba(0, 0, 0, 0.15) 0px 0px 8px;
}


/* Accordion */
.accordionMod .panel-heading .accordion-toggle {
    position: relative;
    cursor: pointer;
    margin: 0;
    padding: 10px 45px;
}

.accordion-body,.panel-heading {
    background: #fff;
    border-radius: 3px;
    padding: 0;
}

.accordionMod .panel-heading .accordion-toggle .icon:before {
    content: "\f067";
    font-family: FontAwesome;
    display: block;
    width: 14px;
    height: 14px;
    position: absolute;
    left: 15px;
    top: 11px;
}

.accordionMod .panel-heading .accordion-toggle .iconActive:before {
    content: "\f068";
    font-family: FontAwesome;
}

.accordionMod .panel-heading .current {
    color: #fff;
    border-top-left-radius: 3px;
    border-top-right-radius: 3px;
	text-shadow:1px 1px 1px #666;
}

.contact-box,.contact-box i,.contact-box p,.contact-box h3 {
    -webkit-transition: all .5s ease-in-out 0;
    -moz-transition: all .5s ease-in-out 0;
    -o-transition: all .5s ease-in-out 0;
    -ms-transition: all .5s ease-in-out 0;
    transition: all .5s ease-in-out 0;
}


/* Contact Box */
.contact-box {
    text-align: center !important;
    -webkit-box-shadow: 0 -1px 0 0 rgba(0,0,0,0.05) inset;
    box-shadow: 0 -1px 0 0 rgba(0,0,0,0.05) inset;
    -webkit-transition: background .5s ease-in-out;
    -moz-transition: background .5s ease-in-out;
    -o-transition: background .5s ease-in-out;
    -ms-transition: background .5s ease-in-out;
    transition: background .5s ease-in-out;
    margin: 0 0 20px;
    padding: 32px 28px;
}

.contact-box:hover {
	border: none;
}

.contact-box i {
    font-size: 48px;
}


/* Home page posts section */
.blog-showcase {
    padding: 0;
}

.blog-showcase ul {
    margin: 0;
    padding: 0;
    list-style: none;
    width: 100%;
    display: block;
    overflow: hidden;
}

.blog-showcase ul li {
    position: relative;
    display: inline-block;
}

.blog-showcase ul li:last-child {
    padding-right: 0 !important;
}

.blog-showcase ul li.blog-first-el {
    padding-right: 270px;
}

.blog-showcase ul li.blog-first-el .blog-showcase-extra-info {
    zoom: 1;
    filter: alpha(opacity=100);
    filter: alpha(opacity=100);
    opacity: 1;
}

.blog-showcase ul li.blog-first-el .blog-showcase-thumb {
    border-right: 0;
}

.blog-showcase ul li img,.blog-showcase-extra-info,.blog-showcase ul li {
    -webkit-transition: all 0.3s ease-in-out 0s;
    -moz-transition: all 0.3s ease-in-out 0s;
    -o-transition: all 0.3s ease-in-out 0s;
    -ms-transition: all 0.3s ease-in-out 0s;
    transition: all 0.3s ease-in-out 0s;
}

.blog-showcase-thumb {
    position: relative;
    overflow: hidden;
    z-index: 20;
    margin-bottom: 5px;
    width: 297px;
}

.blog-showcase-thumb:hover .showcase-blog-overlay {
    zoom: 1;
    filter: alpha(opacity=50);
    filter: alpha(opacity=50);
    opacity: .5;
}

.blog-showcase-extra-info {
    width: 277px;
    height: 180px;
    z-index: 10;
    margin: 0;
    position: absolute;
    left: 297px;
    top: 2px;
    overflow: hidden;
    zoom: 1;
    filter: alpha(opacity=0);
    filter: alpha(opacity=0);
    opacity: 0;
}

.blog-showcase-extra-info span {
    display: block;
    border: 1px solid rgba(0,0,0,0.1);
    border-left: none;
    border-right: 0;
    margin-bottom: 5px;
    line-height: 24px;
}

.blog-showcase-extra-info span a {
    font-size: 10px;
    color: #999;
}

.blog-showcase-title {
    font-size: 13px;
    font-weight: bold;
    line-height: 20px !important;
    display: inline-block;
    margin-bottom: 0;
    color: #333;
}

.blog-showcase-more {
    font-size: 12px;
    text-decoration: underline;
}

.web-normal i {
    display: inline-block;
    margin: 15px;
}


/* Isotope Portfolio  Gallery */
#options {
    padding: 10px 0 25px;
}

#options li {
    float: left;
    margin: 4px 8px 4px 0;
}

#options li a {
    display: inline-block;
    background: #fafafa;
    color: #727272;
    font-size: 16px;
    text-decoration: none;
    padding: 7px 20px;
	border:1px solid #ddd;
}

.portfolio-pad {
    margin-bottom: 30px;
}

.portfolio .item {
    position: relative;
    overflow: hidden;
}

.isotope-item {
    z-index: 2;
}

.isotope-hidden.isotope-item {
    pointer-events: none;
    z-index: 1;
}

.isotope,.isotope .isotope-item {
    -webkit-transition-duration: .8s;
    -moz-transition-duration: .8s;
    -o-transition-duration: .8s;
    -ms-transition-duration: .8s;
    transition-duration: .8s;
}

.isotope {
    -webkit-transition-property: height,width;
    -moz-transition-property: height,width;
    -o-transition-property: height,width;
    -ms-transition-property: height,width;
    transition-property: height,width;
}

.isotope .isotope-item {
    -webkit-transition-property: 0;
    -moz-transition-property: 0;
    -o-transition-property: 0;
    -ms-transition-property: 0;
    transition-property: 0;
}

.isotope.no-transition,.isotope.no-transition .isotope-item,.isotope .isotope-item.no-transition {
    -webkit-transition-duration: 0;
    -moz-transition-duration: 0;
    -o-transition-duration: 0;
    -ms-transition-duration: 0;
    transition-duration: 0;
}

.isotope.infinite-scrolling {
    -webkit-transition: none;
    -moz-transition: none;
    -o-transition: none;
    -ms-transition: none;
    transition: none;
}


/* Utility */
.progress {
    height: 40px;
}

.progress .progress-bar {
    font-size: 15px;
    font-weight: 600;
    line-height: 40px;
    padding-left: 20px;
    text-align: left;
    text-shadow: 1px 1px 1px #666;
}

a.mobile-menu {
    color: #000;
    cursor: pointer;
}

.mobile-menu {
    height: 40px;
    position: absolute;
    right: 0;
    top: 25px;
}

.google-maps {
    height: 400px;
}

.google-maps img {
  	max-width: none;
}

.tabs ul.posts li img,.author-content,li.work img,.recentworks .pic,.img-caption,a.prev,a.next,.scrollup,#options li a,.portfolio img.pic,.portfolio .img-caption {
    border-radius: 2px;
}

#search-form form,ul.post-meta,.sidebar ul,ul.tabs,.testimonials ul,ul.why,.panel-heading h3,.features .panel-heading h4,#options ul,.gallery ul {
    margin: 0;
}

#horizontal-tabs ul.tabs li,#vertical-tabs ul.tabs li,.content h3,.latest-posts h4 a {
    color: #666;
}

ul.posts {
    padding: 0;
}

ul.posts li {
    list-style: none;
}

ul.posts span.color {
    color:#727272;
}

/*Project Carousel*/

.recentworks ul,.our-clients ul,ul#tweets {
    list-style: none;
    margin: 0;
}

.our-clients ul,#footer ul {
    list-style: none;
}

ul#projects-carousel {
    overflow: hidden;
    position: relative;
    list-style: none;
    margin: 0;
    padding: 0;
    float: left;
}

.portfolio-item {
    background: url("../img/bg_off.png") repeat;
    border-radius: 3px;
    -webkit-box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 3px rgba(0, 0, 0, 0.1);
    border: 1px solid #ddd;
    padding: 4px;
	overflow:hidden;
	display:block;
}

.portfolio-item img {
	display:block;
	width: 100%;
}

.fullscreen {
    position: absolute;
    left: 50%;
    top: 65%;
    color: #fff;
    font-size: 18px;
    margin-top: -30px;
    margin-left: -24px;
    width: 60px;
    height: 60px;
	opacity:0;
}

.fullscreen i {
    color: #fff !important;
    -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=100)";
    filter: alpha(opacity=100);
    opacity: 1;
    z-index: 11;
    background: rgba(0,0,0,0.6);
    padding: 16px 18px;
    font-size: 16px;
    border-radius: 100px;
}

.portfolio-item-link {
    display: block;
    position: relative;
}

.post-item-link {
    display: block;
    position: relative;
    overflow: hidden;
    margin: 0;
}

.post-body {
    padding: 4px;
    background: url("../img/bg_off.png") repeat;
    border: 1px solid #DDDDDD;
    border-radius: 3px;
}

.portfolio-item-link span.portfolio-item-hover, .post-item-link span.post-item-hover, .img-hover {
	background: rgba(50,50,50,0.75)
}


.portfolio-item.round img {
    border-radius: 2px;
}

a.portfolio-item-link {
    line-height: 0;
    padding: 0;
    margin: 0;
}

.portfolio-item-link span.portfolio-item-hover,.post-item-link span.post-item-hover, .img-hover {
    position: absolute;
    width: 100%;
    height: 100%;
    -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=0)";
    filter: alpha(opacity=0);
    opacity: 0;
 /* IE 8 */
    top: 0;
    left: 0;
    -webkit-transition: all 0.35s ease-out;
    -moz-transition: all 0.35s ease-out;
    -o-transition: all 0.35s ease-out;
    -ms-transition: all 0.35s ease-out;
    transition: all 0.35s ease-out;
}

.portfolio-item-link span.portfolio-item-hover:hover,.post-item-link span.post-item-hover:hover, .img-hover:hover {
    background-position: center center;
}

.portfolio-item-title {
    text-align: center;
    padding: 10px 5px 10px 5px;
    background: #FFF;
}

.portfolio-item-title a {
    font-weight: 600;
    font-size: 14px;
    font-family: "Open Sans", Arial, Verdana;
    color: #666;
    -webkit-transition: all 0.25s ease-out;
    -moz-transition: all 0.25s ease-out;
    -o-transition: all 0.25s ease-out;
    -ms-transition: all 0.25s ease-out;
    transition: all 0.25s ease-out;
}

.portfolio-item-title a:hover {
    text-decoration: none;
}

.portfolio-item-title p {
    font-style: italic;
    font-size: 12px;
    margin-bottom: 0;
	text-align:center;
}


/* Circle items */
.ch-item {
    width: 100%;
    height: 100%;
    position: relative;
    cursor: default;
}

.ch-info-wrap i {
    color: #FFFFFF;
    float: left;
    font-size: 28px;
    left: 35%;
    line-height: 80px;
    position: relative;
    z-index: 5;
	text-shadow:0 3px 0 rgba(0, 0, 0, 0.1);
}

.ch-info-wrap {
    position: absolute;
    width: 80px;
    height: 80px;
    border-radius: 50%;
    background: #666;
    
    top: 10px;
    left: 10px;
}

.ch-info {
    position: absolute;
    width: 80px;
    height: 80px;
    border-radius: 50%;
    -webkit-box-shadow: 0 0 0 5px rgba(0,0,0,0.2);
    box-shadow: 0 0 0 5px rgba(0,0,0,0.2);
    -webkit-transition: all 0.4s ease-in-out;
    -moz-transition: all 0.4s ease-in-out;
    -o-transition: all 0.4s ease-in-out;
    -ms-transition: all 0.4s ease-in-out;
    transition: all 0.4s ease-in-out;
}

.ch-info > div {
    display: block;
	position: absolute;
	width: 100%;
	height: 100%;
	border-radius: 50%;
	background-position: center center;
	
	-webkit-backface-visibility: hidden; /*Just for webkit to have a smooth font*/
}

.ch-info .ch-info-front {
	-webkit-transition: all 0.6s ease-in-out;
	-moz-transition: all 0.6s ease-in-out;
	-o-transition: all 0.6s ease-in-out;
	-ms-transition: all 0.6s ease-in-out;
	transition: all 0.6s ease-in-out;
}

.ch-info .ch-info-back {
    -webkit-transform: scale(1.5);
	-moz-transform: scale(1.5);
	-o-transform: scale(1.5);
	-ms-transform: scale(1.5);
	transform: scale(1.5);
	box-shadow: inset 0 0 3px rgba(0,0, 0, 0.6);
	-moz-box-shadow: inset 0 0 3px rgba(0,0, 0, 0.6);
	-webkit-box-shadow: inset 0 0 3px rgba(0,0, 0, 0.6);
	
	-webkit-transition: all 0.4s ease-in-out 0.2s;
	-moz-transition: all 0.4s ease-in-out 0.2s;
	-o-transition: all 0.4s ease-in-out 0.2s;
	-ms-transition: all 0.4s ease-in-out 0.2s;
	transition: all 0.4s ease-in-out 0.2s;
	opacity: 0;
}

.ch-item:hover .ch-info-front {
	-webkit-transform: scale(0);
	-moz-transform: scale(0);
	-o-transform: scale(0);
	-ms-transform: scale(0);
	transform: scale(0);
} 

.ch-item:hover .ch-info-back {
	-webkit-transform: scale(1);
	-moz-transform: scale(1);
	-o-transform: scale(1);
	-ms-transform: scale(1);
	transform: scale(1);
	
	opacity: 1;
	pointer-events: auto;
}


/* Team Section */

.team .item .team-member-links a.facebook:hover,.member-social.dark a.facebook:hover,header .social li.facebook:hover,footer .social li.facebook:hover {
    background: #4C66A4;
}

.team .item .team-member-links a.dribbble:hover,.member-social.dark a.dribbble:hover,header .social li.dribbble:hover,footer .social li.dribbble:hover {
    background: #EA4C89;
}

.team .item .team-member-links a.twitter:hover,.member-social.dark a.twitter:hover,header .social li.twitter:hover,footer .social li.twitter:hover {
    background: #2C77BA;
}

.team .item .team-member-links a.gplus:hover,.member-social.dark a.gplus:hover,header .social li.gplus:hover,footer .social li.gplus:hover {
    background: #9e0b0f;
}

.team .item .team-member-links a.linkedin:hover,.member-social.dark a.linkedin:hover,header .social li.linkedin:hover,footer .social li.linkedin:hover {
    background: #069;
}

.team .item .team-member-links a.pinterest:hover,.member-social.dark a.pinterest:hover,header .social li.pinterest:hover,footer .social li.pinterest:hover {
    background: #C92228;
}

header .social li.rss:hover,footer .social li.rss:hover {
    background: #f60;
}


/* Team member*/

.team-member {
    display: block;
    margin: 0 auto 50px;
    width: 100%;
    max-width: 350px;
    padding: 0;
}

.team-member-image {
    float: none;
    overflow: visible;
    height: 0;
    width: 100%;
    padding-bottom: 100%;
}

.team-member-image img {
    border-radius: 50%;
}

.team-member-links {
    top: 0;
    min-height: 1px;
    border-radius: 50%;
    box-shadow: 0 0 0 10px rgba(255,255,255,0.25) inset;
    -webkit-transition: all 0.25s ease;
    transition: all 0.25s ease;
}

.team-member:hover .team-member-links {
    box-shadow: 0 0 0 175px rgba(50,50,50,0.75) inset;
}

.team-member-links-list {
    filter: progid:DXImageTransform.Microsoft.Alpha(opacity=0);
    opacity: 0;
    -webkit-transition: opacity 0.25s ease;
    transition: opacity 0.25s ease;
}

.team-member:hover .team-member-links-list {
    filter: progid:DXImageTransform.Microsoft.Alpha(opacity=100);
    opacity: 1;
}

.team-member-links-item {
    font-size: 22px;
    line-height: 44px;
    height: 44px;
    width: 44px;
    margin: 5px;
    position: relative;
    border-radius: 50%;
    background-color: #fff;
    color: #666;
}

.team-member-links-item:hover,.color_alternate .team-member-links-item:hover,.color_primary .team-member-links-item:hover {
    background-color: #f8862c;
    color: #fff;
}

.team-member-meta {
    margin-left: 0;
    min-height: 1px;
    padding: 15px 0 0;
    text-align: center;
}

.team-member-name {
    margin-bottom: 6px;
}

.team-member-role {
    font-size: 13px;
    margin-bottom: 10px;
    color: #999;
}

.team-member-description p {
    margin-bottom: 0;
	text-align:center;
}

.member-social.dark a {
    background: #9e9e9e;
    -webkit-transition: background .5s ease-in-out;
    -moz-transition: background .5s ease-in-out;
    -o-transition: background .5s ease-in-out;
    -ms-transition: background .5s ease-in-out;
    transition: background .5s ease-in-out;
}

.team .item .team-member-links a {
    -webkit-transition: all .5s ease-in-out;
    -moz-transition: all .5s ease-in-out;
    -o-transition: all .5s ease-in-out;
    -ms-transition: all .5s ease-in-out;
    transition: all .5s ease-in-out;
}

.member-social a {
    width: 36px;
    float: left;
    text-align: center;
    margin: 0 6px 6px 0;
    padding: 7px 0 6px;
	border-radius: 2px;
}

.member-social a i {
    display: block!important;
    font-size: 20px;
    color: #fff;
    margin: 0 auto!important;
}

.pagination > .active > a,.pagination > .active > span,.pagination > .active > a:hover,.pagination > .active > span:hover,.pagination > .active > a:focus,.pagination > .active > span:focus {
    border-color: transparent;
}

.pager li > a:hover {
	border: none;
}

.menu > ul li {
    float: none;
}

.navbar-toggle {
    border: none;
    border-radius: 2px;
    padding: 9px 10px 5px;
}

input,button,select,textarea {
    font-family: "Open Sans",Helvetica,Arial,sans-serif;
}

strong,.author-content .data a {
    font-weight: 600;
}

.breadcrumbs ul,.portfolio-single .sidebar h3 {
    margin-top: 5px;
}

.nivo-caption h2,.pagination-centered {
    text-align: center;
}

.page article.post .post-image,.portfolio-single .recentwork_wrapper .item {
    margin-bottom: 25px;
}

ol li ol.childlist .comment-des,header nav li,.avatar {
    float: left;
}

.recentworks li.slide,.portfolio-wrap {
    overflow: hidden;
}

footer a,.contact-box:hover,#options li a.selected,header .top-bar,header .top-bar a,header .social li:hover i,footer .social li:hover i,.content-box:hover>.content-box-icon i,div.content-box div.content-box-icon:hover,div.content-box div.content-box-icon:hover i,#footer h3,.contact-box:hover h3 {
    color: #fff;
}

.contact-box p {
    text-align: center !important;
}

.panel-group .panel,.accordionMod .accordion-group {
    margin-bottom: 15px;
}

.panel {
	border: 1px solid #DDDDDD;
}
