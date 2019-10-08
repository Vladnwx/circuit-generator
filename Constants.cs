using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    public static class Constants
    {
        public const int Tabl_start_column = 4; // Номер стобца, с которого начинается таблица схемы (столбец Е)
        public const int First_fider_column = Tabl_start_column+2; // Номер стобца, с которого начинается фидер
        public const int fider_width_column = 2; // Число столбцов, которое занимает фидер
        public const int Width_column = 11; // Число столбцов, которое занимает фидер
        public const int Tabl_start_row = 4; // Номер строки, с которого начинается таблица схемы (срока 4)
        public const int First_fider_row = Tabl_start_row+11; // Номер строки, с которой начинается фидер
        public const int Last_fider_row = Tabl_start_row+60; // Номер строки, которой заканчивается фидер

        public const int QF_fider_row = Tabl_start_row+11; // Номер строки, в которую пишется нумерация автоматов
        public const int QF_type_fider_row = Tabl_start_row+12; // Номер строки, в которую пишется тип автоматов
        public const int QF_setpoint_fider_row = Tabl_start_row+13; // Номер строки, в которую пишется уставка автоматов
        public const int QF_p_fider_row = Tabl_start_row+14; // Номер строки, в которую пишется количество полюсов автоматов

        public const int Fider_info_row = Tabl_start_row+21; // Номер строки, в которую пишется сборная информация по фидеру
        public const int Fider_image_row = Tabl_start_row+22; // Номер строки, в которую пишется изображение на плане
        public const int Fider_phase_row = Tabl_start_row+23; // Номер строки, в которую пишется номер фазы фидера L1, L2, L3 или L1 L2 L3 (3-х фазная)
        public const int Fider_id_row = Tabl_start_row+24; // Номер строки, в которую пишется обозначение фидера на планах расположения
        public const int Fider_u_row = Tabl_start_row+25; // Номер строки, в которую пишется выбранное напряжение на фидере
        public const int Fider_p_row = Tabl_start_row+26; // Номер строки, в которую пишется мощность на фидере, кВт
        public const int Fider_cos_row = Tabl_start_row+27; // Номер строки, в которую пишется cos(fi) на фидере
        public const int Fider_i_row = Tabl_start_row+28; // Номер строки, в которую пишется Ток на фидере
        public const int Fider_name_potr_row = Tabl_start_row+29; // Номер строки, в которую пишется наименование потребителя фидере
        public const int Fider_lenght_row = Tabl_start_row+33; // Номер строки, в которую пишется длина фидера
        public const int Fider_poteri_row = Tabl_start_row+35; // Номер строки, в которую пишется потери фидера
        public const int Fider_cabel_row = Tabl_start_row+37; // Номер строки, в которую пишется выбранный кабель фидера
        public const int Fider_start_row = Tabl_start_row+43; // Номер строки, в которую пишется начало фидера
        public const int Fider_finish_row = Tabl_start_row+44; // Номер строки, в которую пишется конец фидера
        public const int Fider_cable_marka_row = Tabl_start_row+46; // Номер строки, в которую пишется марка выбранного кабеля фидера
        public const int Fider_cable_metal_type_row = Tabl_start_row+48; // Номер строки, в которую пишется материал жил выбранного кабеля фидера
        public const int Fider_prokladka_type_row = Tabl_start_row+50; // Номер строки, в которую пишется способ прокладки кабеля фидера
        public const int Fider_cabel_jila_row = Tabl_start_row+52; // Номер строки, в которую пишется жильность выбранного кабеля фидера
        public const int Fider_truba_type_row = Tabl_start_row+56; // Номер строки, в которую пишется тип трубы кабеля фидера
        public const int Fider_truba_lenght_row = Tabl_start_row+58; // Номер строки, в которую пишется длина трубы кабеля фидера
        public const int Fider_truba_diam_row = Tabl_start_row+60; // Номер строки, в которую пишется диаметр трубы кабеля фидера

        public const int QF_vvod_row = Tabl_start_row+4; // Номер строки, в которую пишется вводной автомат
        public const int QF_type_vvod_row = Tabl_start_row+5; // Номер строки, в которую пишется тип вводного автомата
        public const int QF_setpoint_vvod_row = Tabl_start_row+6; // Номер строки, в которую пишется уставка вводного автомата
        public const int QF_p_vvod_row = Tabl_start_row+7; // Номер строки, в которую пишется количество полюсов вводного автомата
        
        public const int Tabl_vvod_column = Tabl_start_column+9; // Номер столбца, в которую пишется табличка ввода

        public const int Tabl_nagr_column = Tabl_start_column+15; // Номер столбца, в которую пишется табличка нагрузок

        public const int Tabl_potreb_column = Tabl_start_column+21; // Номер столбца, в которую пишется табличка потребности в кабеле и трубах

    }
}
