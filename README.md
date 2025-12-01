# CG-Exam-Activity

For the stars:
<img width="819" height="332" alt="image" src="https://github.com/user-attachments/assets/8ee24993-c6d0-44bc-b1ff-917d99a20b1e" />
There are 3 different copies of the same material so that the values aren't shared. The stars are spheres put into the sky and split into thirds, each third given one of the 3 copies of the star material. The shader takes in a colour and intensity, then returns the colour * intensity to simulate bloom, as colour values can be multiplied to create a bloom effect (greater than 1,1,1 for the RGB values will make a white that glows into bloom). A script attached to each star takes in the amount of time it should take to go from fully dark to fully bloomed, turns that into a value to multiply time.deltatime with so that it takes the specified amount of time to change. Once it reaches maximum intensity, it starts going down, then once it reaches minimum, it goes up again. Each of the 3 materials start at different intensity offsets so that they aren't all changing together and looking artificial.

<img width="1300" height="954" alt="stars diagram" src="https://github.com/user-attachments/assets/38942208-481f-4d2b-9537-0147a47b2fa7" />


For the water:
<img width="1257" height="538" alt="image" src="https://github.com/user-attachments/assets/453183b4-3334-4624-9627-7080c2302ea3" />
It takes in a water texture, foam texture, and scroll x speed. It scrolls the water and foam uvs by adding a float2 with the scroll x speed and no y value so the water only scrolls horizontally, then multiplying it by _Time.y for the water and _Time.y * 0.5 for the foam so they scroll at different speeds. The textures are then sampled with the scrolled uv data and added together then multiplied by 0.5 so they don't get too bright after being added together. 

<img width="1300" height="954" alt="water diagram" src="https://github.com/user-attachments/assets/098f6537-864e-4f45-989d-cdd0e9f28fb5" />
