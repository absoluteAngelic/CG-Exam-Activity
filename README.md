# CG-Exam-Activity

For the stars:
<img width="819" height="332" alt="image" src="https://github.com/user-attachments/assets/8ee24993-c6d0-44bc-b1ff-917d99a20b1e" />
There are 3 different copies of the same material so that the values aren't shared. The stars are spheres put into the sky and split into thirds, each third given one of the 3 copies of the star material. The shader takes in a colour and intensity, then returns the colour * intensity to simulate bloom, as colour values can be multiplied to create a bloom effect (greater than 1,1,1 for the RGB values will make a white that glows into bloom). A script attached to each star takes in the amount of time it should take to go from fully dark to fully bloomed, turns that into a value to multiply time.deltatime with so that it takes the specified amount of time to change. Once it reaches maximum intensity, it starts going down, then once it reaches minimum, it goes up again. Each of the 3 materials start at different intensity offsets so that they aren't all changing together and looking artificial.

<img width="1300" height="954" alt="stars diagram" src="https://github.com/user-attachments/assets/38942208-481f-4d2b-9537-0147a47b2fa7" />


For the water:
<img width="1257" height="538" alt="image" src="https://github.com/user-attachments/assets/453183b4-3334-4624-9627-7080c2302ea3" />
It takes in a water texture, foam texture, and scroll x speed. It scrolls the water and foam uvs by adding a float2 with the scroll x speed and no y value so the water only scrolls horizontally, then multiplying it by _Time.y for the water and _Time.y * 0.5 for the foam so they scroll at different speeds. The textures are then sampled with the scrolled uv data and added together then multiplied by 0.5 so they don't get too bright after being added together. 

<img width="1300" height="954" alt="water diagram" src="https://github.com/user-attachments/assets/098f6537-864e-4f45-989d-cdd0e9f28fb5" />

For the bushes:

<img width="481" height="82" alt="{FBC5BBDE-E17A-48A3-90E3-4F986A2E5191}" src="https://github.com/user-attachments/assets/4f767c4a-3c23-4a2f-985a-0f4bcb06866f" />

The first shader I utilized in our recreation of Contra was a transparency shader. I did this through my recreation of the game's bushes. I first found a bush pixel art image online that I felt fit the game's environment. Then after I found an image suitable for the game's environment I grabbed the transparency shader from canvas to use to apply to the bushes. After grabbing the shader I put the shader code into unity and then created a material from that shader file. I then dragged in my bush object into the Main Texture slot from the shader code so the bush would appear.  After I applied the material to a quad the bush appeared. After resizing, position and duplicating the quad I was left with a satisfied recreation of Contra’s bushes. I felt this fit our creation/solution as we focused on implementing the games environment over interaction and the bushes are an important part of Contra's game environment.

<img width="1070" height="201" alt="{93E681E5-9B25-46CE-99C9-D11ABF455753}" src="https://github.com/user-attachments/assets/32ab5bf1-805d-4cd7-a01f-2da8eda924b9" />

For the rocks:

<img width="454" height="238" alt="{1874701E-95E7-4884-8675-CB20C172B134}" src="https://github.com/user-attachments/assets/18a6443c-be12-4f45-b40c-d45e691803ca" />

The second shader I utilized in our recreation of Contra was a basic Texture shader. I did this by first finding a nice 2d Rock texture that I felt was similar and reminded me of Contra’s rocks. After finding that image I grabbed the shader code of the basic Texture shader as my main focus was to get the texture to apply onto an object and adjust its color for it to fit the environment more as we started with just a basic brown object for the dirt without any rocks. I then added the shader code into unity and created a material using it. I then added the texture and the beige color tint to give it more character and make it fit better with the environment. The material was then applied to cubes which would hold the texture. I then began duplicating the blocks and placing them around to create a pattern of rocks that I felt both looked nice and fit the game. The final finishing touches came into the scaling of the objects. I think this approach fit our solution as again, we focused on the games environment over recreating functionality and I felt we ended up achieving that in our final build and recreation. 

<img width="2081" height="274" alt="Rocks" src="https://github.com/user-attachments/assets/a9ead329-fcf0-415b-9d56-15fb54074aae" />



Sources For Bushes and Rocks:
https://opengameart.org/content/pixel-art-simple-trees
https://opengameart.org/content/handpainted-rock-textures-rock01png

