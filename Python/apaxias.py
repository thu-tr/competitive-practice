# Input
# The input contains a single name. Each name contains only lowercase letters (a–z), 
# no whitespace, a minimum length of 1 character, and a maximum length of 250 characters.
# Output
# The output contains the compact version of the name: any time the same letter 
# appears two or more times in sequence, it must be replaced by a single instance of that letter.

name = input()
result = name[0]
i = 1
j = 0

while i < len(name):
    if name[i] != result[j]:
        result += name[i]
        i += 1
        j+= 1
    else:
        i += 1

print(result)