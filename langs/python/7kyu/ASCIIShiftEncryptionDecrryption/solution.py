""" Problem
Ascii Shift Encryption/Decryption
The goal of this kata is to create a very simple ASCII encryption and decryption. The encryption algorithm should shift each character's charcode by the character's current index in the string (0-based).

The input strings will never require to go outside of the ASCII range.

Example:
  p | a | s | s | w | o | r | d # Plaintext
+ 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 # Shift (add)
  p | b | u | v | [ | t | x | k # Ciphertext
The decryption should reverse this:

  p | b | u | v | [ | t | x | k # Ciphertext
- 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 # Shift (subtract)
  p | a | s | s | w | o | r | d # Plaintext
"""
def ascii_encrypt(text):
    """ procedural solution
    l = []
    for ind, x in enumerate(text):
        l.append(chr(ord(x) + ind))
    return ''.join(l)"""
    # list comprehension solution
    return ''.join([chr(ord(x) + ind) for ind, x in enumerate(text)])
    
def ascii_decrypt(text):
    """ procedural solution
    l = []
    for ind, x in enumerate(text):
        l.append(chr(ord(x) - ind))
    return ''.join(l)"""
    # list comprehension solution
    return ''.join([chr(ord(x) - ind) for ind, x in enumerate(text)])
    
print(ascii_encrypt('PASSWORD'), ascii_decrypt(ascii_encrypt('PASSWORD')))