using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TilesetPadder {
    public partial class Form1 : Form {
        private string _inputFileString;
        private string _outputFileString;

        public Form1() {
            InitializeComponent();
        }


        private void export_Click(object sender, EventArgs e) {
            int tileWidth = int.Parse(width.Text);
            int tileHeight = int.Parse(height.Text);

            Image tilesheet = Bitmap.FromFile(_inputFileString);
            int numCols = tilesheet.Width / tileWidth;
            int numRows = tilesheet.Height / tileHeight;
            Image padded = new Bitmap(tilesheet.Width + numCols * 2, tilesheet.Height + numRows * 2);

            using ( Graphics g = Graphics.FromImage(padded) ) {
                for ( int row = 0; row < numRows; row++ ) {
                    for ( int col = 0; col < numCols; col++ ) {

                        int xOffset = col * tileWidth;
                        int yOffset = row * tileHeight;
                        int destXOffset = xOffset + col * 2 + 1;
                        int destYOffset = yOffset + row * 2 + 1;

                        // draw the main body of the image
                        Rectangle srcRect = new Rectangle(xOffset, yOffset, tileWidth, tileHeight);
                        Rectangle destRect = new Rectangle(destXOffset, destYOffset, tileWidth, tileHeight);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        // then a strip on each edge

                        // left
                        srcRect = new Rectangle(xOffset, yOffset, 1, tileHeight);
                        destRect = new Rectangle(destXOffset - 1, destYOffset, 1, tileHeight);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        // right
                        srcRect = new Rectangle(xOffset + tileWidth - 1, yOffset, 1, tileHeight);
                        destRect = new Rectangle(destXOffset + tileWidth, destYOffset, 1, tileHeight);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        // top
                        srcRect = new Rectangle(xOffset, yOffset, tileWidth, 1);
                        destRect = new Rectangle(destXOffset, destYOffset - 1, tileWidth, 1);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        // bottom
                        srcRect = new Rectangle(xOffset, yOffset + tileHeight - 1, tileWidth, 1);
                        destRect = new Rectangle(destXOffset, destYOffset + tileHeight, tileWidth, 1);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        // then a pixel for each corner
                        srcRect = new Rectangle(xOffset, yOffset, 1, 1);
                        destRect = new Rectangle(destXOffset - 1, destYOffset - 1, 1, 1);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        srcRect = new Rectangle(xOffset + tileWidth - 1, yOffset, 1, 1);
                        destRect = new Rectangle(destXOffset + tileWidth, destYOffset - 1, 1, 1);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        srcRect = new Rectangle(xOffset + tileWidth - 1, yOffset + tileHeight -1, 1, 1);
                        destRect = new Rectangle(destXOffset + tileWidth, destYOffset + tileHeight, 1, 1);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);

                        srcRect = new Rectangle(xOffset, yOffset + tileHeight - 1, 1, 1);
                        destRect = new Rectangle(destXOffset - 1, destYOffset + tileHeight, 1, 1);
                        g.DrawImage(tilesheet, destRect, srcRect, GraphicsUnit.Pixel);
                    }
                }
            }

            padded.Save(_outputFileString);
        }

        private void loadTileset_Click(object sender, EventArgs e) {
            DialogResult dialogResult = this.openFileDialog1.ShowDialog();
            if ( dialogResult == DialogResult.OK ) {
                _inputFileString = openFileDialog1.FileName;
                this.inputFile.Text = _inputFileString;
                FileInfo f = new FileInfo(_inputFileString);
                int extensionLength = f.Extension.Length;
                _outputFileString = _inputFileString.Substring(0, _inputFileString.Length - extensionLength) +
                                    "_padded" + f.Extension;
                this.outputFile.Text = _outputFileString;
            }
        }

        private void chooseOutput_Click(object sender, EventArgs e) {
            DialogResult dialogResult = saveFileDialog1.ShowDialog();
            if ( dialogResult == DialogResult.OK ) {
                _outputFileString = saveFileDialog1.FileName;
            }
        }       
    }
}
