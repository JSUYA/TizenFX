using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace Tizen.NUI.Samples
{
    public class CanvasViewSample : IExample
    {
        private View root;
        private Control control;
        public static readonly string svgPath = CommonResource.GetDaliResourcePath() + "DaliDemo/cartman.svg";
        public void Activate()
        {
            Window window = NUIApplication.GetDefaultWindow();

            root = new View()
            {
                Size = window.Size,
                BackgroundColor = new Color(0.8f, 0.8f, 0.8f, 0.6f),
                ParentOrigin = ParentOrigin.Center,
                PivotPoint = PivotPoint.Center,
                PositionUsesPivotPoint = true,
            };
            window.Add(root);

            /* Temporary SVG Image Code for thorvg test*/
            ImageVisual svgVisual = new ImageVisual();
            svgVisual.URL = svgPath;

            View svgImageView = new ImageView();
            svgImageView.Background = svgVisual.OutputVisualMap;
            root.Add(svgImageView);
            //




            //Do create CavansView!!!

        }

        public void Deactivate()
        {
            if (root != null)
            {
                NUIApplication.GetDefaultWindow().Remove(root);
                root.Dispose();
            }
        }
    }
}
