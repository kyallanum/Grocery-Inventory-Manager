
using Microsoft.Maui.Graphics.Platform;
using System.Reflection;

namespace Grocery_Inventory_Manager.Drawables
{
    class ProfileImage : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            Microsoft.Maui.Graphics.IImage genericProfile;
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            using (Stream stream = assembly.GetManifestResourceStream("Grocery_Inventory_Manager.Resources.Images.avatar.png"))
            {
                genericProfile = PlatformImage.FromStream(stream);
            }

            if (genericProfile != null)
            {
                Microsoft.Maui.Graphics.IImage downsized = genericProfile.Downsize(125, true);
                canvas.DrawImage(downsized, 133, 62, downsized.Width, downsized.Height);
            }

        }
    }
}
