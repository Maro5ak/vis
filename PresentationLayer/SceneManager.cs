using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer {
    internal class SceneManager {
        public static void ChangeScene<T, P>(T oldScene, P newScene) where T : Form where P : Form {
            newScene.Location = oldScene.Location;
            newScene.StartPosition = FormStartPosition.Manual;
            newScene.FormClosing += delegate { oldScene.Close(); };
            newScene.Show();
            oldScene.Hide();
        }
    }
}
