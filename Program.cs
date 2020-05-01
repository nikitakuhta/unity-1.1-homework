using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(20);

            // Печать в консоль всех сотрудников
            repository.Print("База данных до преобразования");

            // Увольнение всех работников с именем "Агата"
            repository.DeleteWorkerByName("Агата");

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после первого преобразования");

            // Увольнение всех работников с именем "Аделина"
            repository.DeleteWorkerByName("Аделина");

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после второго преобразования");


            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников
            // создаю базу с изначально 20 сотрудниками

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников
            Repository secondRepository = new Repository(40);
            secondRepository.Print("Новая база данных до увольнения");
            secondRepository.FireUntilCount(30); // увольнять, пока не останется 30 человек
            secondRepository.Print("Новая база данных после увольнения до 30 человек");

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб

            Repository thirdRepository = new Repository(50);
            thirdRepository.Print("Третья БД до увольнения");
            thirdRepository.DeleteWorkerBySalary(30000);
            thirdRepository.Print("Третья БД после увольнения всех, кто получает больше 30к рублей");

            #endregion

        }
    }
}
