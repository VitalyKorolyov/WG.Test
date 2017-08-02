var es = require('event-stream');
var gulp = require('gulp');
var concat = require('gulp-concat');
var connect = require('gulp-connect');

gulp.task('default', ['build', 'vendor']);

var source = {
    js: {
        src: [
            'src/app/app.js',
            'src/app/**/module.js',
            'src/app/**/!(module)*.js'
        ]
    }
};

var scripts = require('./src/app.scripts.json');

var destinations = {
    js: 'src/build'
};

gulp.task('connect', function () {
    connect.server({
        root: 'src'
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
        paths.push('src/' + scripts.paths[script]);
    });
    gulp.src(paths)
        .pipe(concat('vendor.js'))
        .pipe(gulp.dest(destinations.js));
});

gulp.task('watch', function () {
    gulp.watch(source.js.src, ['build']);
});
