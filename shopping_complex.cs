using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_pr_6._2
{
    class cafe_Subsystem1
    {
        public void ServeCustomer(string Name)
        {
            Name = "Клиент делает заказ";
        }

        public void WriteOrder(string Name)
        {
            Name = "Официант приносит заказ";
        }

        public void ShockHelp(string Name)
        {
            Name = "Клиенту попался таракан в пицце и он упал в обморок";
        }

        public void PrepareFood(string Name)
        {
            Name = "Шеф-повар готовил пиццу и не заметил, что забежал таракан";
        }
    }

    class bowling_Subsystem2
    {
        public void Game(string Name)
        {
            Name = "Команды соревнуются в боулинге";
        }

        public void Mishap(string Name) 
        {
            Name = "Один из учасников случайно папал шаром в бар";
        }

        public void Victory(string Name) 
        {
            Name = "Команда 'Огурцы' одержала победу ";
        }

        public void CelebrateVictory(string Name) 
        {
            Name = "Команды сдружились и сели отмечать победу";
        }
    }

    class playground_Subsystem3
    {
        public void Weeping(string Name)
        {
            Name = "Мама отвела своего плачущего сына в игровую комнату";
        }
        public void Game(string Name)
        {
            Name = "Дети играбют в прятки";
        }

        public void Problem(string Name)
        {
            Name = "Один из детей очень хорошо спрятался, что его не могли найти даже взрослые";
        }

        public void Adult(string Name)
        {
            Name = "Ребенок сам ушел домой";
        }

    }

    class shopping_complex
    {

    }
}
