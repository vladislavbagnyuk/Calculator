using Calculator.CustomControls;
using Calculator.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]

namespace Calculator.iOS.Renderers
{
    public class CustomEditorRenderer : EditorRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            // Disabling the keyboard
            this.Control.InputView = new UIView();
        }
    }
}