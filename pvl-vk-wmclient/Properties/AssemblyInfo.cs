using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Resources;

// Общие сведения об этой сборке предоставляются следующим набором
// атрибутов. Отредактируйте значения этих атрибутов, чтобы изменить
// общие сведения об этой сборке.
[assembly: AssemblyTitle("ВКонтакте для смартфонов")]
[assembly: AssemblyDescription("Клиент социальной сети ВКонтакте для мобильных устройств под управлением Windows Mobile 6.5")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Paul von Lecter")]
[assembly: AssemblyProduct("Paul von Lecter VK Client")]
[assembly: AssemblyCopyright("Copyright © Paul von Lecter 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Установка значения False в параметре ComVisible делает типы в этой сборке невидимыми
// для COM-компонентов. Если необходим доступ к типу в этой сборке из
// COM, следует установить атрибут ComVisible в TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("ee01ccc0-9e43-4646-bb0a-b54a2108f463")]

// Сведения о версии сборки состоят из следующих четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии
//      Номер построения
//      Редакция
//
[assembly: AssemblyVersion("1.0.0.0")]

// Следующий атрибут служит для подавления предупреждения FxCop "CA2232: Microsoft.Usage: добавьте к сборке STAThreadAttribute",
// так как приложение для устройства не поддерживает поток STA.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")]
[assembly: NeutralResourcesLanguageAttribute("ru-RU")]
