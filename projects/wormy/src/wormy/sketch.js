async function setup() {
  createCanvas(windowWidth, windowHeight);
  noSmooth();
  
  width_x = 100;
  width_y = 100;
  
  let leapsize = 1;
  
  graphic = createGraphics(width_x, width_y);
  
  let x_index = 0;
  let y_index = 0;
  
  let x_prev = 0;
  let y_prev = 0;
  
  let x_prev2 = 0;
  let y_prev2 = 0;
  
  let pat_index = 0;

  // setPixel(7, 0);
  // setPixel(0, 1);
  // setPixel(3, 1);
  // setPixel(5, 1);
  // setPixel(3, 2);
  // setPixel(4, 2);
  // setPixel(5, 2);
  
  while (x_index != (width_x - 1) || y_index != (width_y - 1)) {
    let fun = random(0, 5);
    x_prev2 = x_prev;
    y_prev2 = y_prev;
    x_prev = x_index;
    y_prev = y_index;
    switch(int(fun))
    {
      case 1: x_index += leapsize; break;
      case 2: y_index += leapsize; break;
      case 3: x_index -= leapsize; break;
      case 4: y_index -= leapsize; break;
    }
    
    // print(x_index + ", " + y_index);
    
    if (x_index >= width_x) x_index -= leapsize;
    if (y_index >= width_y) y_index -= leapsize;
    if (x_index < 0) x_index += leapsize;
    if (y_index < 0) y_index += leapsize;
    
    setPixel(x_index, y_index, 255, 0, 0);
    graphic.updatePixels();
    if(pat_index == 0) setPixel(x_prev, y_prev, 0, 255, 0);
    if(pat_index == 1) setPixel(x_prev, y_prev, 0, 150, 0);
    graphic.updatePixels();
    pat_index = pat_index == 0 ? 1 : 0;
    await sleep(0.1);
  }
  
  // setPixel(x_index, y_index);
}

function setPixel(x, y, r, g, b)
{
  graphic.loadPixels();
  const pixels = graphic.pixels;
  
  let i = (x % width_x + y * width_y) * 4;
  pixels[i+0] = r;
  pixels[i+1] = g;
  pixels[i+2] = b;
  pixels[i+3] = 255;

}

function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}

function draw() {
  clear();
  image(graphic, 0, 0, width, height)
}