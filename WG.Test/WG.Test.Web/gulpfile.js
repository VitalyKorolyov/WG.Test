var es = require('event-stream');
var gulp = require('gulp');
var concat = require('gulp-concat');
var connect = require('gulp-connect');

gulp.task('default', ['build', 'vendor']);

var source = {
    js: {
        src: [
            'wwwroot/app/app.js',
            'wwwroot/app/**/module.js',
            'wwwroot/app/**/!(module)*.js'
        ]
    }
};

var scripts = require('./wwwroot/app.scripts.json');

var destinations = {
    js: 'wwwroot/build'
};

gulp.task('connect', function () {
    connect.server({
        root: 'wwwroot'
    });
});

gulp.task('build', function () {
    return es.merge(gulp.src(source.js.src))
        .pipe(concat('app.js'))
        .pipe(gulp.dest(destinations.js));
});

gulp.task('vendor', function () {
    var paths = [];
    scripts.preBuild.forEach(function (script) {
        paths.push('wwwroot/' + scripts.paths[script]);
    });
    gulp.src(paths)
        .pipe(concat('vendor.js'))
        .pipe(gulp.dest(destinations.js));
});

gulp.task('watch', function () {
    gulp.watch(source.js.src, ['build']);
});
