from PIL import Image
import sys
arg1=int(sys.argv[1]);arg2=int(sys.argv[2]);arg3=int(sys.argv[3])
argExeName=sys.argv[4]
sizeOffset=int(sys.argv[5])
im=Image.open("blank.png")
im.convert('RGBA')
imgblender=Image.new('RGBA',im.size,(arg1,arg2,arg3))
m,n=im.size
im.paste(imgblender,(0,0,m,n),imgblender)
icon=Image.open("exeicon.png")
icon.convert('RGBA')
icon=icon.resize((48+2*sizeOffset,48+2*sizeOffset))
p=Image.new('RGBA',icon.size,(arg1,arg2,arg3))
x,y=icon.size
p.paste(icon,(0,0,x,y),icon)
icon=p
im.paste(icon,(55-sizeOffset,55-sizeOffset))
im.save(argExeName+".tile.png")

im=Image.open("blankSmall.png")
im.convert('RGBA')
imgblender=Image.new('RGBA',im.size,(arg1,arg2,arg3))
m,n=im.size
im.paste(imgblender,(0,0,m,n),imgblender)
icon=Image.open("exeicon.png")
icon.convert('RGBA')
icon=icon.resize((48+2*sizeOffset,48+2*sizeOffset))
p=Image.new('RGBA',icon.size,(arg1,arg2,arg3))
x,y=icon.size
p.paste(icon,(0,0,x,y),icon)
icon=p
im.paste(icon,(13-sizeOffset,13-sizeOffset))
im.save(argExeName+".tileSmall.png")
'''
我不想看这个脚本了!真的不想看了!
'''
