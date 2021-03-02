using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.BaseComponents.VectorGraphics;



namespace Tizen.NUI.Samples
{
    public class CanvasViewSample : IExample
    {
        private View root;
        private CanvasView canvasView ;
        
        public void Activate()
        {
            Window window = NUIApplication.GetDefaultWindow();

            root = new View()
            {
                Size = window.Size,
                BackgroundColor = new Color(1.0f, 1.0f, 1.0f, 1.0f),
                ParentOrigin = ParentOrigin.Center,
                PivotPoint = PivotPoint.Center,
                PositionUsesPivotPoint = true,
            };
            window.Add(root);

            //Do create CavansView!!!
            // Test Code!!!!!!!!!!!!!!!
            //CanvasView canvasView = new CanvasView(new Vector2(100, 100));
            canvasView = new CanvasView(window.Size)
            {
                Size = window.Size,
                ParentOrigin = ParentOrigin.Center,
                PivotPoint = PivotPoint.Center,
                PositionUsesPivotPoint = true,
            };

            //canvasView.AddPaint(new Paint()); << Make Error!
            Shape shape = new Shape();
            shape.AddRect(10, 10, 100, 100, 20, 20);
            shape.SetFillColor(new Color(1.0f, 0.0f, 0.0f, 1.0f));
            canvasView.AddPaint(shape);

            Shape shape2 = new Shape();
            shape2.AddRect(80, 80, 100, 100, 10, 10);
            shape2.SetFillColor(new Color(0.0f, 0.0f, 1.0f, 0.5f));
            canvasView.AddPaint(shape2);

            Shape shape3 = new Shape();
            shape3.AddRect(140, 30, 100, 100, 30, 30);
            shape3.SetFillColor(new Color(0.0f, 1.0f, 1.0f, 1.0f));
            canvasView.AddPaint(shape3);

            root.Add(canvasView);
        }

        public void Deactivate()
        {
            if (root != null)
            {
                NUIApplication.GetDefaultWindow().Remove(root);
                canvasView.Dispose();
                root.Dispose();
            }
        }
    }
}
