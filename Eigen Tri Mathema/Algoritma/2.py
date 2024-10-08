def longest(sentence):
    words = sentence.split() #Split Sentence by space
    get_word = ""

    #Get Longest word by iterating
    for word in words:
        prev_word = len(get_word)
        if len(word) > prev_word:
            get_word = word

    len_word = len(get_word) #Get length of chosen word
    return get_word, len_word

sentence = input("Please input a sentences: ") #Get user input
get_word, len_word = longest(sentence)
print(f"{get_word}: {len_word} char(s)")
