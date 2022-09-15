using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui01.Settings;

public class ListSettings
{
    /// <summary>
    /// Начальное количество элементов в списке
    /// </summary>
    public int InitialListSize { get; set; } = 10;

    /// <summary>
    /// Сколько элементов загружать при необходимости отобразить дополнительные элементы списка
    /// </summary>
    public int PageSize { get; set; } = 5;

    /// <summary>
    /// Загружать элементы списка автоматически при достижении конца списка загруженных элементов
    /// </summary>
    public bool PageAutoLoad { get; set; }
}
