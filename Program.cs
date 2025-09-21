using ImageMagick;

var rootPath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\");
using var image = new MagickImage(Path.Combine(rootPath, @"logo.png"));
image.Resize(0, 80);

// logo-edited.avif and logo-edited.png look different
await image.WriteAsync(Path.Combine(rootPath, @"logo-edited.avif"), MagickFormat.Avif);
await image.WriteAsync(Path.Combine(rootPath, @"logo-edited.png"), MagickFormat.Png);

image.Quality = 100;
// logo-edited-100 and logo-edited-100 look fine
await image.WriteAsync(Path.Combine(rootPath, @"logo-edited-100.avif"), MagickFormat.Avif);
// await image.WriteAsync(Path.Combine(rootPath, @"logo-edited-100.png"), MagickFormat.Png);