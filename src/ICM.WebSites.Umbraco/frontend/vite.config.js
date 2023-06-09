const path = require('path')

export default {
    root: path.resolve(__dirname, 'src'),
    build: {
        outDir: '../dist',
        assetsDir: '.',
        emptyOutDir: true,
        rollupOptions: {
            input: {
                'main.js': 'src/js/main.js',
                'style.css': 'src/scss/style.scss'
            },
            output: {
                entryFileNames: 'js/[name]',
                assetFileNames: '[ext]/[name][extname]'
            },
        }
    },
    resolve: {
        alias: {
            '~bootstrap': path.resolve(__dirname, 'node_modules/bootstrap'),
        }
    },
    server: {
        port: 44400,
        hot: true
    }
}