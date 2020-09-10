# AI Visitor Interactive System based on Image Recognition and Voice Analysis

This is an interactive system assisting receptionists by deploying 3D virtual characters, providing guest-receiving functions, integrated with image recognition and voice analysis.

## Introduction Video
[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/cPyP9Xj_8s0/0.jpg)](https://www.youtube.com/watch?v=cPyP9Xj_8s0)


## Tool used
* Unity engine
* C#


## Overview
* System Introduction </br>
Why we build this system?
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_2.png" width="500">
Traditionally, visitor reception services for companies, factories, institutions, and communities are provided for consulting or assist through the professionals at the counter. However, it needs to employ many professionals in different institutes, factories, and/or floors, which greatly increases personnel costs and cause management difficulties. In addition, the current visitor services can only assist to contact persons or consult the certain locations but neglects to remember visitors’ preferences and analyze their characteristics to provide a more friendly interaction, such as greetings, concerns, reminders or conversations, so as to mitigate the strangeness and anxiety of visitors.
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_3.png" width="500">
In view of this, we design an interactive AI visitor system based on image analysis and speech recognition with the virtual portraits. In addition, the system can also provide community interaction among internal staff in companies, institutions, and communities through the development of virtual gardens, community photo stickers and virtual pet breeding games, which can enhance the working atmosphere.
With this system, both the internal staff and external visitors can enjoy these special experiences through the artificial intelligence services.

</br>
* System Functions
There are four main functions in the system.
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_4.png" width="500">
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_5.png" width="500">
1. 3D virtual character interaction
Combined with real-time image recognition with the webcam, the information of visitors such as the age, expression, posture and wearing can be obtained and can provide instant and vivid audio-based interaction. This also can significantly reduce the strangeness and anxiety of visitors while providing the variety of audio-based consultations, special contact notifications and message services and thus makes the service be richer experiences.
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_6.png" width="500">
2. Personnel connection
By means of voice input and touch screen, visitors can contact with any staff. The map, showing the route of any locations like bathrooms, meeting rooms, or specific offices, will assist users with audio guide.
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_7.png" width="500">
3. Bulletin
The bulletin is for the display of latest news, introduction video and collaborations information.
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_8.png" width="500">
4. Camera
Visitors can take pictures and download them by the QR code easily.

</br>
* Key Technologies
There are three key technologies in our system.
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_9.png" width="500">

1. Image Recognition
    1. We use Openpose to detect human body, hand facial. For more info about Openpose Unity Plugin please check this website: https://github.com/CMU-Perceptual-Computing-Lab/openpose_unity_plugin
    1. The system can detect visitors’ age, gender, expression, posture and whether they’re coming or leaving.
1. Voice Analysis
    1. We built our corpus/dataset and use API from Google to translate speech to text. With the pre-defined keywords and the texts, the system is able to determine which feature the user wants to use.
1. 3D virtual character
    1. We built 3D virtual character models, applied pre-developed movements on virtual characters’ for vividness by using Unity and Red Pill Live.


* Comparison
What makes our system different from other applications? Take a look at these four aspects:
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_10.png" width="500"> </br>
1. Responding ways: The system can respond to the visitors via audio, text and motions of the character.
1. Precise responding: All the contents the character responds are customizable, so all the responding can be accurate.
1. Scope of application: Since the system is customizable, there are lots of places suitable for this system. For example, companies, department stores, communities, schools and factories.
1. Interactivity: The 3D character can greet visitors actively and have different reactions in regard to visitors’ age, gender, expression and posture, which makes the system more vivid. Thus the system is more interactive than others.


* Conclusion
<img src="https://github.com/Kris-Hung/AI-Visitor-Interactive-System-based-on-Image-Recognition-and-Voice-Analysis/blob/master/pics/ppt_12.png" width="500">
This “AI Visitor Interactive System” is developed in order to assist receptionists for places like companies, department stores, communities, schools and factories. Every features/functions in the system are easily to customized based on different needs or circumstances.


## Team
* A-Chi Huang, Jamie Su, Amy Lee and me :1
* Mentor: Prof. Jia-Ming Liang, PhD / Prof. Shih-Lin Wu, PhD
