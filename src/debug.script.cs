tDebug.txt="ok:"
covx ok,vars.s.txt,0,0
tDebug.txt+=vars.s.txt
tDebug.txt+="\r"
tDebug.txt+="bsy:"
covx busy,vars.s.txt,0,0
tDebug.txt+=vars.s.txt
tDebug.txt+="\r"
tDebug.txt+="blk:"
covx OkBlocks,vars.s.txt,0,0
tDebug.txt+=vars.s.txt
tDebug.txt+="\rlast:"
tDebug.txt+=commands.last.txt
tDebug.txt+="\rqueue:\r"
tDebug.txt+=commands.queue.txt
tDebug.txt+="history:"
tDebug.txt+=commands.history.txt
tDebug.txt+="--END--"

//scroll
if(tDebug.x==420) //Pop out
{
  debug_i=320
}
if(tDebug.x==320)
{
  debug_i=30
}
if(tDebug.x==30)
{
  if(tDebug.val_y==tDebug.maxval_y) //Is is scrolled to max?
  {
    tDebug.val_y=0 
    debug_i=420 //Reset
  }else
  {
    tDebug.val_y+=tDebug.h-20 //Scroll down
    if(tDebug.val_y>=tDebug.maxval_y)
    {
      tDebug.val_y=tDebug.maxval_y //Go back to bottom
    }
  }
}
tDebug.x=debug_i