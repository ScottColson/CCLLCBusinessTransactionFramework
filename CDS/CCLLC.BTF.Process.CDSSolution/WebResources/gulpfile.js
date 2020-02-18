/// <binding ProjectOpened='watch' />

var gulp = require('gulp');
var sourcemaps = require('gulp-sourcemaps');
var watch = require('gulp-watch');

gulp.task('watch', function () {    
    gulp.watch('Common/out/**/*.js', gulp.series('build-common'));
    gulp.watch('ClientHooks/out/**/*.js', gulp.series('build-clienthooks'));
    gulp.watch('ClientUI/out/**/*.js', gulp.series('build-clientui'));
});

gulp.task('build-common', () => {
    return gulp.src(
		'./Common/out/common.js'
	)
        .pipe(sourcemaps.init(
			{ 
				loadMaps: true 
			}))
        .pipe(sourcemaps.write('./',
			{ 
				includeContent: false,
				sourceRoot: '/common/src'
			}))
        .pipe(gulp.dest('./WebResources/ccllc_/js/transactions'));
});

gulp.task('build-clienthooks', () => {
    return gulp.src(
        './ClientHooks/out/clienthooks.js'
    )
        .pipe(sourcemaps.init(
            {
                loadMaps: true
            }))
        .pipe(sourcemaps.write('./',
            {
                includeContent: false,
                sourceRoot: '/ClientHooks/src'
            }))
        .pipe(gulp.dest('./WebResources/ccllc_/js/transactions'));
});

gulp.task('build-clientui', () => {
    return gulp.src(
        './ClientUI/out/clientui.js'
    )
        .pipe(sourcemaps.init(
            {
                loadMaps: true
            }))
        .pipe(sourcemaps.write('./',
            {
                includeContent: false,
                sourceRoot: '/ClientUI/src'
            }))
        .pipe(gulp.dest('./WebResources/ccllc_/js/transactions'));
});
