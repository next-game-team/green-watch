using UnityEditor;

namespace Editor.Inspector
{
    [CustomPropertyDrawer(typeof(InfoPanelDictionary))]
    public class InfoPanelDictionaryDrawer : DictionaryDrawer<InfoPanelEnum, InfoPanelController> {}
}