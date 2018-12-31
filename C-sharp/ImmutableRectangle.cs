using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class ImmutableRectangle
    {
        int Length { get; }
        int Height { get; }

        public ImmutableRectangle(int length, int height)
        {
            Length = length;
            Height = height;
        }

        // This is immutable because instead of editing the properties of an existing rectangle, we return an entirely new rectangle with new dimensions
        public ImmutableRectangle Grow(int length, int height) =>
            new ImmutableRectangle(Length+length,Height+height);
    }
}
