# MCCToolChestDecryptor
the decryption is real

## How it works
I reimplemented the decrypt method and gave you a command prompt

## Raw decrypted structure

> [!NOTE]
> All data is stored in little-endian
> This means that the lowest value number comes first, instead of last.
>
> Say `x` (32-bit integer) = `10 00 00 00` (in hex),
> In big-endian, this would be equal to `268435456`, however in little-endian this is equal to `16`.

I will probably work on cleaning up the method but for now it works so it's fine I guess? Anyway, the structure of the decrypted file is quite simple.\
You can see this by opening the prompt and simply typing "`raw`" (to look at the bytes like `\xFF\x00\xFF\x00`...) or "`raw-s`" (same as raw, but instead of byte view it converts bytes to characters like "`a b c d `" \[accounted for unicode\])

There is no file header, the data just flows.

### Structure visualiser (raw)
![visualise-structure-raw](https://github.com/CheatBreakerX/MCCToolChestDecryptor/blob/master/assets/brave_dJ13Oqe063.png?raw=true)

### Structure visualiser (raw-s)
![visualise-structure-raw-s](https://github.com/CheatBreakerX/MCCToolChestDecryptor/blob/master/assets/brave_JTqx4YQaPp.png?raw=true)

## Real life example

![dnSpy](https://github.com/CheatBreakerX/MCCToolChestDecryptor/blob/master/assets/dnSpy_kaXiaJILAe.png?raw=true)
![prompt](https://github.com/CheatBreakerX/MCCToolChestDecryptor/blob/master/assets/MCCToolChestDecryptor_kdDP9xWfqZ.png?raw=true)
