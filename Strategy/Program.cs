using Strategy.Models;

var imageStorage = new ImageStorage(new JpegCompressor(), new BlackAndWhiteFilter());

imageStorage.StoreImage("avatar.png");