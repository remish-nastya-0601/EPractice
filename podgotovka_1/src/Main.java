import java.io.IOException;
import java.lang.reflect.Array;
import java.text.DecimalFormat;
import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        new SameElementsInArray();
    }

    public static class MaxDelitel { //Реализовать алгоритм Эвклида для нахождения наибольшего общего делителя двух чисел на Java в консоли.
        MaxDelitel() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.println("Введите первое число:");
                    int fnum = input.nextInt();
                    System.out.println("Введите второе число:");
                    int snum = input.nextInt();
                    int d = 0;
                    int max = fnum;
                    if(max < snum){
                        max = snum;
                    }
                    for(int i = 1; i <= max/2; i++){
                        if(fnum%i == 0 && snum%i == 0 && i > d){
                            d = i;
                        }
                    }
                    System.out.printf("Наибольший общий делитель чисел %1s и %2s - %3s", fnum, snum, d);

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class SameElementsInArray{ //8. Создать программу, которая находит пересечение двух массивов.
        SameElementsInArray() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.println("Введите элементы (через пробел) первого массива:");
                    String fm = input.nextLine();
                    String[] fmsplit = fm.split(" ");
                    System.out.println("Введите элементы (через пробел) второго массива:");
                    String sm = input.nextLine();
                    String[] smsplit = sm.split(" ");
                    ArrayList<String> sameElem = new ArrayList<>();
                    for(int i = 0; i < fmsplit.length; i++){
                        for(int j = 0; j <smsplit.length; j++){
                            if(fmsplit[i].equals(smsplit[j])){
                                sameElem.add(fmsplit[i]);
                                smsplit[j] = "";
                                break;
                            }
                        }
                    }
                    System.out.printf("%1s\n\n", sameElem);

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class IsArrayPolindrom { //3. Создать программу, которая проверяет, является ли массив симметричным относительно его центра.
        IsArrayPolindrom() {
            while (true) {
                try {
                    Scanner text = new Scanner(System.in);
                    System.out.println("Введите элементы массива через пробел: ");
                    String line = text.nextLine();
                    String[] lineM = line.split(" ");
                    int lineL = lineM.length -1;
                    String result = "Массив является палиндромом\n";
                    for(int i=0; i < Math.floor(lineM.length / 2); i++){
                        if(!(lineM[i].equals(lineM[lineL - i]))){
                            result = "Массив НЕ является палиндромом!\n";
                            break;
                        }
                    }
                    System.out.println(result);

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }


    public static class NArifmProgr{ //Вычислить значение n-го члена арифметической прогрессии
        NArifmProgr() {
            while (true) {
                try {
                    Scanner inpunt = new Scanner(System.in);
                    System.out.println("Введите первый член арифметической прогрессии:");
                    int a = inpunt.nextInt();
                    System.out.println("Введите разность прогрессии:");
                    int d = inpunt.nextInt();
                    System.out.println("Введите номер члена:");
                    int n = inpunt.nextInt();
                    int an = a + d * (n - 1);
                    System.out.printf("%1s-й член данного ряда - %2s\n\n",n, an);
                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class IsPalindrom { //10. Создать программу, которая определяет, является ли строка палиндромом.
        IsPalindrom() {
            while (true) {
                try {
                    Scanner text = new Scanner(System.in);
                    System.out.println("Введите строку: ");
                    String line = text.nextLine();
                    String[] lineM = line.split("");
                    int lineL = lineM.length -1;
                    String result = "Строка является палиндромом\n";
                    for(int i=0; i < Math.floor(lineM.length / 2); i++){
                        if(!(lineM[i].equals(lineM[lineL - i]))){
                            result = "Строка НЕ является палиндромом!\n";
                            break;
                        }
                    }
                    System.out.println(result);

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class PopularWord { //Создать программу, которая находит наиболее встречающееся слово в заданной строке
        PopularWord() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите строку: ");
                    String str = input.nextLine();
                    str = str.toLowerCase();
                    String[] words = str.split("[(\\p{Punct}) (\\p{javaWhitespace})]");
                    Map<String, Integer> prom = new HashMap<String, Integer>();
                    for (String word: words) {
                        prom.put(word, prom.getOrDefault(word, 0) + 1);
                    }
                    int max = 0;
                    for (String el: prom.keySet()){
                        if(prom.get(el.toString()) > max)
                            max = prom.get(el);
                    }
                    System.out.println("В предлодении чаже всего встречается слово(ва):" );
                    for (String el: prom.keySet()){
                        int res = prom.get(el.toString());
                        if(res == max) {
                            System.out.printf("%1s: %2s раз(а)\n", el, res);
                        }
                    }
                    System.out.println();
                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class UpperCase{ //Создать программу, которая преобразует заданный текст в верхний регистр
        UpperCase() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите строку: ");
                    String str = input.nextLine();
                    String res = str.toUpperCase();
                    System.out.println("\nСтрока в верхнем регистре: \n" + res + "\n");
                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class IsAnagram{ //Создать программу, которая проверяет, является ли заданное слово анаграммой другого заданного слова
        IsAnagram() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите первое слово: ");
                    String word1 = input.nextLine();
                    word1 = word1.split("[(\\p{Punct}) (\\p{javaWhitespace})]")[0] ;
                    System.out.printf("Введите второе слово: ");
                    String word2 = input.nextLine();
                    word2 = word2.split("[(\\p{Punct}) (\\p{javaWhitespace})]")[0] ;

                    boolean res = false;
                    if (word1.equals(word2)) {
                        System.out.println("\nСлова " + word1 + " и " + word2 + " являются 1 словом\n");
                        continue;
                    }
                    else if (word1.length() != word2.length()) {
                        res = false;
                    }
                    else{
                        char[] w1 = word1.toCharArray();
                        char[] w2 = word2.toCharArray();
                        Arrays.sort(w1);
                        Arrays.sort(w2);
                        res = Arrays.equals(w1, w2);
                    }

                    System.out.println("\nСлова " + word1 + " и " + word2 + (res ? "": " не") + " являются анаграммой\n");

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class AlphabetSort{ //Создать программу, которая сортирует слова в строке в алфавитном порядке
        AlphabetSort() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите строку: ");
                    String str = input.nextLine();
                    str = str.toLowerCase();
                    String[] words = str.split("[(\\p{Punct}) (\\p{javaWhitespace})]");
                    String res = Arrays.stream(words).sorted().collect(Collectors.joining(" "));
                    System.out.println("\nСлова в алфавитном порядке: \n" + res + "\n");
                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class DeleteSymbol { //Создать программу, которая удаляет заданный символ из строки
        DeleteSymbol() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите строку: ");
                    String str = input.nextLine();
                    System.out.printf("Введите символ: ");
                    String symb = input.nextLine();
                    while (symb.length() != 1) {
                        System.out.println("Нужно ввести ровно 1 символ!");
                        System.out.printf("Введите символ: ");
                        symb = input.nextLine();
                    }
                    String res = str.replaceAll(symb, "");
                    System.out.println("\nИзменённая строка: \n" + res + "\n");

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class WordsCount{ //Создать программу, которая определяет, сколько раз встречается слово в заданной строке
        WordsCount() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите строку: ");
                    String str = input.nextLine();
                    System.out.printf("Введите слово: ");
                    String word = input.nextLine();
                    String s = word.replaceAll("[(\\p{Punct}) (\\p{javaWhitespace})]", "").toLowerCase();
                    str = str.toLowerCase();
                    String[] words = str.split("[(\\p{Punct}) (\\p{javaWhitespace})]");
                    int res = (int)Arrays.stream(words).filter(n -> n.equals(s)).count();
                    System.out.println("\nКоличество повторений слова " + s + ": " + res + "\n");
                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class DistinctSimbols { //Создать программу, которая из введенной строки убирает повторяющиеся символы
        DistinctSimbols() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите строку: ");
                    String str = input.nextLine();
                    String[] words = str.split("");
                    String res = Arrays.stream(words).distinct().collect(Collectors.joining());
                    System.out.println("\nСтрока без повторяющихся символов: \n" + res + "\n");
                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class ReverseString { //Создать программу, которая преобразует строку из последовательности слов, разделенных пробелами, в строку, где слова переставлены в обратном порядке
        ReverseString() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите строку из последовательности слов, разделенных пробелами: ");
                    String str = input.nextLine();
                    String[] words = str.split(" ");
                    String[] words_reverse = new String[words.length];
                    String res;
                    for(int i= words.length-1; i>=0; i--){
                        words_reverse[words.length-1-i] = words[i];
                    }
                    res = String.join(" ", words_reverse);
                    System.out.println("\nСлова в обратном порядке: \n" + res + "\n");

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }
    }

    public static class SimpleMultipliers{ //Разложить заданное натуральное число на простые множители
        SimpleMultipliers() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите целое положительное число: ");
                    int n = input.nextInt();
                    while (n <= 0) {
                        System.out.println("Нужно ввести целое число больше 0");
                        System.out.printf("Введите целое положительное число: ");
                        n = input.nextInt();
                    }
                    if(n==1) System.out.println("\nЧисло " + n + " не является простым, т.к. делится только само на себя\n");
                    else if(isSimple(n))
                        System.out.println("\nЧисло " + n + " является простым и делится только на 1 и на себя\n");
                    else {
                        Map<Integer, Integer> map = new HashMap<Integer, Integer>();
                        int prom_n = n;
                        while (!isSimple(prom_n)){
                            for (int j = 2; j <= prom_n / 2; j++) {
                                if (prom_n % j == 0) {
                                    prom_n /= j;
                                    map.put(j, map.getOrDefault(j, 0) + 1);
                                    break;
                                }
                            }
                        }
                        map.put(prom_n, map.getOrDefault(prom_n, 0) + 1);
                        System.out.println("Простые множители числа " + n + ":");
                        for (Integer name: map.keySet()) {
                            String key = name.toString();
                            String value = map.get(name).toString();
                            System.out.println(key + ": " + value + " раз(а)");
                        }
                        System.out.println();
                    }

                } catch (Exception e) {
                    System.out.println("\nНеверный формат!\n");
                }
            }
        }

        boolean isSimple(int num){
            boolean checker = true;
            for (int j = 2; j <= num / 2; j++) {
                if (num % j == 0) {
                    checker = false;
                    break;
                }
            }
            return checker;
        }
    }

    public static class nFibonacci{ //Вычислить значение n-го члена ряда Фибоначчи
        nFibonacci() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    final double fi = (1 + Math.sqrt(5))/2;
                    double res=0;
                    double f1 = 0, f2 = 1;
                    System.out.println("*Первый член ряда - 0*");
                    System.out.printf("Введите номер члена ряда: ");
                    int n = input.nextInt();
                    while (n <= 0) {
                        System.out.println("Нужно ввести число больше 0");
                        System.out.printf("Введите номер члена ряда: ");
                        n = input.nextInt();
                    }
                    n--;
                    res = Math.floor((Math.pow(fi, n) - Math.pow(1 - fi, n))/ Math.sqrt(5));

                    DecimalFormat decimalFormat=new DecimalFormat("#.#");
                    System.out.printf((n+1) + "-ый член ряда Фибоначчи: " + decimalFormat.format(res) + "\n\n");
                } catch (Exception e) {
                    System.out.println("\nЧисло введено в неправильном формате!\n");
                }
            }
        }
    }

    public static class SredneeArifmGeometr { //Подсчитать среднее арифметическое и среднее геометрическое заданного набора чисел
        SredneeArifmGeometr() {
            while (true) {
                try {
                    Scanner input = new Scanner(System.in);
                    double[] numbers;
                    System.out.printf("Введите числа через пробел: ");
                    String n = input.nextLine();
                    try{
                        String[] n_array = n.split(" ");
                        numbers = Arrays.stream(n_array)
                                .mapToDouble(Double::parseDouble)
                                .toArray();
                    }
                    catch (Exception e){
                        System.out.println("\nНеверный формат!\n");
                        continue;
                    }
                    double sum = 0, mult = 1, arifm, geometr;
                    sum = Arrays.stream(numbers).sum();
                    arifm = sum/numbers.length;
                    arifm = Math.floor(arifm*100)/100;

                    for(double num : numbers) {
                        mult *= num;
                    }
                    geometr = Math.pow(mult, 1./numbers.length);
                    geometr = Math.floor(geometr*100)/100;

                    System.out.println("Среднее арифметическое и геометрическое чисел:\n" + arifm + "\t" + geometr + "\n");

                } catch (Exception e) {
                    System.out.println("\nЧисло введено в неправильном формате!\n");
                }
            }
        }
    }

    public static class SimpleNumbers{ //Найти все простые числа в заданном диапазоне
        SimpleNumbers(){
            while(true){
                try {
                    Scanner input = new Scanner(System.in);
                    System.out.printf("Введите нижнюю границу диапазона (включительно): ");
                    int min = input.nextInt();
                    while (min <= 0) {
                        System.out.printf("Нужно ввести число больше 0");
                        System.out.printf("\nВведите нижнюю границу диапазона (включительно): ");
                        min = input.nextInt();
                    }
                    System.out.printf("Введите верхнюю границу диапазона (включительно): ");
                    int max = input.nextInt();
                    while (max <= 1 || max < min) {
                        System.out.printf("Нужно ввести число больше заданного минимального числа (" + min + ") и больше 1");
                        System.out.printf("\nВведите верхнюю границу диапазона (включительно): ");
                        max = input.nextInt();
                    }
                    String result = "";
                    if (min < 2) min = 2;

                    boolean checker = true;
                    for (int i = min; i <= max; i++) {
                        for (int j = 2; j <= i / 2; j++) {
                            if (i % j == 0) {
                                checker = false;
                                break;
                            }
                        }
                        if (checker) result +=i + "\n";
                        checker = true;
                    }

                    //Вывод
                    if (result == "") result = "в заданном диапазоне нет простых чисел";
                    System.out.printf("Простые числа:\n%1$s\n", result);
                }
                catch(Exception e){
                    System.out.println("\nЧисло введено в неправильном формате!\n");
                }
            }
        }
    }








}

