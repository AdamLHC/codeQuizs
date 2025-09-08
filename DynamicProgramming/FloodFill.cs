public class FloodFill()
{

    public int[][] FillColor(int[][] image, int sr, int sc, int color)
    {
        Fill(image, sr, sc, image[sr][sc], color);
        return image;
    }

    private void Fill(int[][] img, int sr, int sc, int targetColor, int fillColor)
    {
        if (sr < 0 || sr >= img.Length || sc < 0 || sc >= img[sr].Length || img[sr][sc] == fillColor || img[sr][sc] != targetColor)
        {
            return;
        }
        img[sr][sc] = fillColor;

        Fill(img, sr + 1, sc, targetColor, fillColor); // up
        Fill(img, sr, sc + 1, targetColor, fillColor); // right
        Fill(img, sr, sc - 1, targetColor, fillColor); // left
        Fill(img, sr - 1, sc, targetColor, fillColor); // down
    }
}