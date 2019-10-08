using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    class Load
    {
      // Добавить список возможного количества фаз
        public string Number_of_phases { get; set; } // Количество фаз
        
        //добавить список типовых мощностей в зависимости от выбранных характеров
        public double Power { get; set; } // Мощность в кВт, добавить проверку мощности (она не может быть отрицательной)
        
        //добавить список типовых косинусов в зависимости от выбранных характеров
        public double Cosphi { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)
        
        public bool Start_load_in_box { get; set; } // Начало нагрузки в щите или ответвление от фидера, добавить проверку, что при отсутствии фидера невозможно поставить нагрузку как начинающуюся не от щита
       
        public string Start_load { get; set; } // начало нагрузки
        
        public string Source_load { get; set; } // Местоположение нагрузки
        
        public int Load_number_coluumn { get; set; } // Номер столбца для нагрузки
        
        public string Type_network { get; set; } // Тип применяемой сети на комплексную нагрузку (трехфазная разводка, с ответвлением в коробке пофазно или однофазная прямо от щита)
        
        // Добавить список возможных характеров нагрузки (Розетки, Светильники, двигатели, нагреватели, шкафчики, комплексная нагрузка) 
        public string Harakter_load { get; set; } // Характер нагрузки (двигатель, розетка, светильник, шкафчик), добавить рекомендации по ограничению одной группы освещения не более 10А. 
        //Елси нагрузка комплексная то давать возможность ввести косинус. Если розетка, то давать ввести количество розеток. 
        //Если светильники, то давать ввести количество светильников и мощность одного. 
        //Если двигатель, то запрашивать данные об установленном выключаетел в шкафу управления двигателем.
       
        public string Type_load { get; set; } // Тип нагрузки (конечная или промежуточная)
        
        public void Add_to_list(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Добавляет нагрузку на лист
        {
           worksheet.Cells[Constants.Fider_phase_row, Load_number_coluumn].Value = Number_of_phases;  
            
           worksheet.Cells[Constants.Fider_p_row, Load_number_coluumn].Value = Power;
            
           worksheet.Cells[Constants.Fider_cos_row, Load_number_coluumn].Value = Cosphi;
          
           worksheet.Cells[Constants.Fider_start_row, Load_number_coluumn].Value = Start_load;
            
           worksheet.Cells[Constants.Fider_finish_row, Load_number_coluumn].Value = Source_load;
           
        }
        public Load() : this("Неизвестно") // Конструктор без параметров
        {
        }
        public Load(string Number_of_phases) : this(Number_of_phases, "Неизвестно") // Конструктор с указанием только числа фаз
        {
        }
        public Load(string Number_of_phases, string Power) : this(Source, Power, "Неизвестно") // Конструктор c мощностью
        {
        }
        public Load(string Number_of_phases, string Power, string Cosphi) : this(Source, Power, Cosphi, "Неизвестно") // Конструктор с косинусом
        {
        }
        public Load(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box) : this(Source, Power, Cosphi, bool Start_load_in_box, "Неизвестно") // Конструктор с указанием начала в щите
        {
        }
        public Load(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box, string Start_load) : this(Source, Power, Cosphi, bool Start_load_in_box, string Start_load, "Неизвестно") // Конструктор с указанием начала нагрузки
        {
        }
        public Load(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box, string Start_load, string Source_load) : this(Source, Power, Cosphi, bool Start_load_in_box, string Start_load, string Source_load, "Неизвестно") // Конструктор с указанием конца нагрузки
        {
        }
        public Load(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box, string Start_load, string Source_load, string Type_network) // Конструктор полный
        {
            this.Number_of_phases = Number_of_phases;
            this.Power = ToDouble(Power);
            this.Cosphi = ToDouble(Cosphi);
            this.Start_load_in_box = ToBoolean(Start_load_in_box);
            this.Start_load = Start_load;
            this.Source_load = Source_load;
            this.Type_network = Type_network;
        }
        
    }
}
