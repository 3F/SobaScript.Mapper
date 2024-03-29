﻿/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2014-2019  Denis Kuzmin < x-3F@outlook.com > GitHub/3F
 * Copyright (c) SobaScript.Mapper contributors: https://github.com/3F/SobaScript.Mapper/graphs/contributors
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
*/

namespace net.r_eg.SobaScript.Mapper
{
    public interface INodeInfo
    {
        /// <summary>
        /// Element name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Description for current element.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Technical description of the method/property.
        /// </summary>
        string Signature { get; }

        /// <summary>
        /// Displays element over the 'Name' property.
        /// Useful for code completion.
        /// </summary>
        string Overname { get; }

        /// <summary>
        /// Aliases to primary name if used.
        /// </summary>
        string[] Aliases { get; }

        /// <summary>
        /// Element type.
        /// </summary>
        NodeType Type { get; }

        /// <summary>
        /// Binding with other node.
        /// </summary>
        NodeIdent Link { get; }
    }
}
