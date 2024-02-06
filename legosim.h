#ifndef LEGOSIM_H
#define LEGOSIM_H

#include <iostream>
#include <vector>
#include <array>

class LegoBrick {
    private:
        int width;
        int length;
        int height;
        std::array<int, 3> location;
        std::vector<std::vector<std::vector<int>>> dimensions;

    public:
        LegoBrick(int w, int l, int h) : width(w), length(l), height(h) {
            dimensions.resize(h+2, std::vector<std::vector<int>>(l, std::vector<int>(w)));
            for (int i = 0; i < height+2; ++i) {
                for (int j = 0; j < length; ++j) {
                    for (int k = 0; k < width; ++k) {
                        if (i == 0)
                        {
                            dimensions[i][j][k] = 3;
                        }
                        else if (i == height+1)
                        {
                            dimensions[i][j][k] = 2;
                        }
                        else
                        {
                            dimensions[i][j][k] = 1;
                        }
                    }
                }
            }
        }

        int getWidth() const { return width; }
        int getLength() const { return length; }
        int getHeight() const { return height; }
        std::array<int, 3> getLocation() const { return location; }
        std::vector<std::vector<std::vector<int>>> getDimensions() const { return dimensions; }

        void setWidth(int w) { width = w; }
        void setLength(int l) { length = l; }
        void setHeight(int h) { height = h; }
        void setLocation(int x, int y, int z) { location = {x, y, z}; }
        void setDimensions(const std::vector<std::vector<std::vector<int>>>& d) { dimensions = d; }
};
#endif