var gulp = require('gulp');

//Using package to minify html 
minifyHtml = require("gulp-minify-html");

var paths = {
    webroot: "./wwwroot/"
};
//Getting Path of Htmlfiles to Minifying
paths.html = paths.webroot + "Htmlfiles/**/*.html";

//Path to Writing minified Files after Minifying
paths.Destination = paths.webroot + "Compressedfile";

gulp.task('minify-html', function () {   // path to your files
    gulp.src(paths.html)
        // Minifying files
        .pipe(minifyHtml())
        // Writing files to Destination
        .pipe(gulp.dest(paths.Destination));
});

// Main task to Call for Minifying html files
gulp.task("demo", ["minify-html"]);