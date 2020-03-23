using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic
{
    class Menu
    {
        List<MenuItem> menuItems;
        public void AddItem(int shortCut, string text, Action action) { }
        public void AddItem(MenuItem item) { }

        public void UpdateItem(MenuItem item) { }
        public void Execute() { }
        public void Render() { }
    }
}
