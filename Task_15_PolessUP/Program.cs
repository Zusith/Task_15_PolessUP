string text = "aabcb";
Console.WriteLine("Ввод: " + text);
Console.WriteLine("Вывод красота строки: " + FindStrBeauty(text));


int FindStrBeauty(string text)
{
    char most_common_element = text.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
    char least_common_element = text.GroupBy(x => x).OrderByDescending(g => g.Count()).Last().Key;
    
    if (most_common_element == least_common_element)
        return text.Length;

    CountMostAndLeastCommonElementsInGroup(text, most_common_element, least_common_element, out int countmost, out int countleast);
    if (countmost == countleast)
        return countmost;

    return countmost - countleast;
}

void CountMostAndLeastCommonElementsInGroup(string text, char most_common_element, char least_common_element, out int countmost, out int countleast)
{
    countmost = 0;
    countleast = 0;
    for (int index = 0; index < text.Length; index++)
    {
        if (text[index] == most_common_element)
            countmost++;
        else if (text[index] == least_common_element)
            countleast++;
    }
}

