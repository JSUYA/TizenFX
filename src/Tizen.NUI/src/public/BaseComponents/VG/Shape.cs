/*
* Copyright(c) 2019 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using Tizen.NUI.Binding;

namespace Tizen.NUI.BaseComponents
{

    namespace VectorGraphics
    {
        /// <summary>
        /// Paint is a class<br />
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public class Shape : Paint
        {
            public Shape() : this(Interop.Shape.New(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            internal Shape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
            {
            }

            /// <summary>
            /// AddRect
            /// </summary>
            /// <param name="x">x</param>
            /// <param name="y">y</param>
            /// <param name="w">w</param>
            /// <param name="h">h</param>
            /// <param name="rx">rx</param>
            /// <param name="ry">ry</param>
            /// <since_tizen> 6 </since_tizen>
            public bool AddRect(float x, float y, float w, float h, float rx, float ry)
            {   
                if (Interop.Shape.AddRect(BaseHandle.getCPtr(this), x, y, w, h, rx, ry))
                    return true;
                return false;
            }

            /// <summary>
            /// SetFillColor
            /// </summary>
            /// <param name="color">color</param>
            /// <since_tizen> 6 </since_tizen>
            public bool SetFillColor(Color color)
            {   
                if (Interop.Shape.SetFillColor(BaseHandle.getCPtr(this), Vector4.getCPtr(color)))
                    return true;
                return false;
            }
            
        }
    }
}
