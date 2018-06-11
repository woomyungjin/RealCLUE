﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Suggestion
    {
        public static readonly List<string> suggestions = new List<string>();
        private static string suggestion;

        public static bool MakeSuggestion(Dictionary<string, Enum> roomObjs)
        {
            if (suggestions.Count >= 3)
            {
                //TODO 추리에 반박하는 이벤트를 실행한다


                return false;
            }
            
            Console.WriteLine("추리 아이템을 하나씩 입력하세요:");
            suggestion = Console.ReadLine();

            #region For Console
            if (!roomObjs.Keys.ToArray().Contains(suggestion))
            {
                Console.WriteLine("추리 아이템을 잘못 입력했습니다, 다시 입력하세요");
                return true;
            }
            #endregion
            
            //Place 타입이면 추리를 무시한다
            if ((CardType)roomObjs[suggestion] == CardType.Place)
            {
                return true;
            }

            //이미 한 추리이면 제거한다
            if (suggestions.Contains(suggestion))
            {
                suggestions.Remove(suggestion);
                return true;
            }
            //처음으로 한 추리이면 추가한다
            else
            {
                suggestions.Add(suggestion);
                return true;
            }


        }
    }
}