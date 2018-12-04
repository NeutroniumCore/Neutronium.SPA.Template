module.exports = {
  baseUrl: "./",
  filenameHashing: false,
  chainWebpack: config => {
    config.module
      .rule('images')
      .test(/\.(png|jpe?g|gif|webp)(\?.*)?$/)
      .use('url-loader')
      .loader('url-loader')
      .tap(() => undefined);
  }
};
